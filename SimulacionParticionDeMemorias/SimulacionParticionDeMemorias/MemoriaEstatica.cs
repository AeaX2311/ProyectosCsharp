using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimulacionParticionDeMemorias {
    public partial class MemoriaEstatica : Form {
        private Unidad memoria;
        private Unidad memoriaDisponibleUsable = new Unidad();
        private Unidad memoriaDisponibleDesperdiciada;
        private Unidad sistemaOperativo;
        private List<ParticionEstatica> particiones = new List<ParticionEstatica>();
        private List<Trabajo> enEspera = new List<Trabajo>();

        public MemoriaEstatica() {
            InitializeComponent();
            cboSistemaOperativo.SelectedIndex = 2;
            cboMemoria.SelectedIndex = 2;
            cboParticion.SelectedIndex = 2;
        }

        private void btnGuardarPrincipales_Click(object sender, EventArgs e) {
            #region Lectura de datos
            try {
                if(cboSistemaOperativo.Text.Equals("") || cboMemoria.Text.Equals(""))
                    throw new Exception("Se esperaba un tipo MB o GB.");
                memoria = new Unidad((double) nudMemoria.Value, cboMemoria.Text);
                sistemaOperativo = new Unidad((double) nudSistemaOperativo.Value, cboSistemaOperativo.Text);
            } catch(Exception ex) {
                MessageBox.Show("Favor de verificar los datos. Adicional: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region Aplicacion de validaciones
            try {
                if(sistemaOperativo.compareTo(memoria) == 1)
                    throw new Exception("Tamaño de sistema operativo no puede ser mayor a la memoria total.");
                if(sistemaOperativo.obtenerMB() * 100 / memoria.obtenerMB() > 30)
                    throw new Exception("Tamaño de sistema operativo no puede abarcar mas del 30%.");

              //  memoriaDisponibleUsable = 
                    memoriaDisponibleDesperdiciada = memoria.restar(sistemaOperativo);
            } catch(Exception ex) {
                MessageBox.Show("Favor de verificar los datos. Adicional: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            lblMemoriaTotalDisponible.Text = memoriaDisponibleUsable.ToString();
            MessageBox.Show("Datos guardados exitosamente.");

            grafica.Series.Add("Sistema operativo");
            grafica.Series["Sistema operativo"].IsValueShownAsLabel = true;
            grafica.Series["Sistema operativo"].ChartType = SeriesChartType.StackedColumn;
            grafica.Series["Sistema operativo"].Points.AddXY("Memoria", sistemaOperativo.obtenerMB());
            grafica.Series.Add("Memoria sin asignar");
            grafica.Series["Memoria sin asignar"].IsValueShownAsLabel = true;
            grafica.Series["Memoria sin asignar"].ChartType = SeriesChartType.StackedColumn;
            grafica.Series["Memoria sin asignar"].Points.AddXY("Memoria", memoriaDisponibleDesperdiciada.obtenerMB());
            
            groupBox1.Enabled = false; groupBox6.Enabled = true;
            groupBox2.Enabled = true; groupBox3.Enabled = true;
        }

        private void btnRegistrarParticiones_Click(object sender, EventArgs e) {
            try {
                if(cboParticion.Text.Equals(""))
                    throw new Exception("Se esperaba que seleccionara un tipo.");

                Unidad current = new Unidad((double) nudParticion.Value, cboParticion.Text);

                //Validar que la particion quepa en la memoria disponible
                if(current.compareTo(memoriaDisponibleDesperdiciada) == 1)
                    throw new Exception("La particion no cabe en la memoria disponible.");

                memoriaDisponibleDesperdiciada = memoriaDisponibleDesperdiciada.restar(current);
                memoriaDisponibleUsable = memoriaDisponibleUsable.sumar(current);
                
                particiones.Add(new ParticionEstatica(particiones.Count + 1, current.optimizarTipo()));
                
                grafica.Series.Add("Partición " + particiones.Count);
                grafica.Series["Partición " + particiones.Count].IsValueShownAsLabel = true;
                grafica.Series["Partición " + particiones.Count].ChartType = SeriesChartType.StackedColumn;
                grafica.Series["Partición " + particiones.Count].Points.AddXY("Memoria", current.obtenerMB());

                grafica.Series["Memoria sin asignar"].Points.RemoveAt(0);
                grafica.Series["Memoria sin asignar"].Points.AddXY("Memoria", memoriaDisponibleDesperdiciada.obtenerMB());
            } catch(Exception ex) {
                MessageBox.Show("Favor de verificar los datos. Adicional: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clearItems();
            rellenarParticiones();
        }

        private void btnAgregarTrabajo_Click(object sender, EventArgs e) {
            Trabajo nuevoTrabajo;
            
            #region Validaciones
            try {
                if(particiones.Count == 0)
                    throw new Exception("No hay particiones registradas.");
                if(cboTrabajo.Text.Equals(""))
                    throw new Exception("Se esperaba un tipo para el trabajo.");
                if(txtIdTrabajo.Text.Equals("") || buscarTrabajoEnParticion(txtIdTrabajo.Text) != null)
                    throw new Exception("El trabajo debe contener un ID UNICO, ejemplo: T1, T2...");

                nuevoTrabajo = new Trabajo(new Unidad((double) nudTrabajo.Value, cboTrabajo.Text), txtIdTrabajo.Text);
            } catch(Exception ex) {
                MessageBox.Show("Favor de verificar los datos. Adicional: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
                       
            //Asignar a particion
            ParticionEstatica selected = null;
            bool auxCabeEnParticion = false;

            foreach(ParticionEstatica p in particiones) {
                if(p.Tamanio.compareTo(nuevoTrabajo.Tamanio) == 1 || p.Tamanio.compareTo(nuevoTrabajo.Tamanio) == 0) {
                    if(p.IsDisponible) {
                        selected = p;
                        break;
                    } else {
                        auxCabeEnParticion = true;
                    }
                }
            }

            if(selected == null) { //No se encontro particion disponible
                if(auxCabeEnParticion) { //Se pone en espera
                    enEspera.Add(nuevoTrabajo);
                    MessageBox.Show("Por el momento no es posible asignar el trabajo a ninguna particion, su ejecucion permanecera en espera. Adicional: Se asignara al terminar algun trabajo.");
                    bitacora.Rows.Add(nuevoTrabajo, "En ESPERA de ser atendido.");
                    mostrarEnEspera();
                    return;
                } else { //Se pone en nunca
                    MessageBox.Show("No es posible asignar el trabajo a ninguna particion. Adicional: Verifique que que el trabajo quepa en el tamaño de alguna particion.");
                    bitacora.Rows.Add(nuevoTrabajo, "NUNCA se asigna.");
                    return;
                }                
            }

            AT(nuevoTrabajo, selected);
        }

        private void AT(Trabajo nuevoTrabajo, ParticionEstatica selected) {
            particiones.ElementAt(selected.Id - 1).agregarTrabajo(nuevoTrabajo);
            MessageBox.Show("Se agrego el nuevo trabajo a la particion " + selected.Id);
            bitacora.Rows.Add(nuevoTrabajo, "Se ASIGNA a partición " + selected.Id + ".");
            
            //Memoria total
            memoriaDisponibleUsable = memoriaDisponibleUsable.restar(nuevoTrabajo.Tamanio);
            lblMemoriaTotalDisponible.Text = memoriaDisponibleUsable.ToString();

            clearItems();
            rellenarParticiones();

            //Alterar grafica "dividir a la mitad"
            Unidad aux = new Unidad(grafica.Series["Partición " + selected.Id].Points[0].YValues[0], "MB");
            grafica.Series["Partición " + selected.Id].Points.RemoveAt(0);
            grafica.Series["Partición " + selected.Id].Points.AddXY("Memoria", aux.restar(nuevoTrabajo.Tamanio).obtenerMB());
            grafica.Series["Partición " + selected.Id].Points.AddXY("Memoria utilizada", nuevoTrabajo.Tamanio.obtenerMB());
        }

        private void btnDesasignarTrabajo_Click(object sender, EventArgs e) {
            ParticionEstatica selected;

            try {
                if(txtIdTrabajoDesasignar.Text.Equals(""))
                    throw new Exception("Se esperaba indicar el ID de un trabajo.");

                selected = buscarTrabajoEnParticion(txtIdTrabajoDesasignar.Text);

                if(selected == null)
                    throw new Exception("No se encontro el trabajo en niguna particion. Favor de verificar que el ID se haya ingresado correctamente.");
            } catch(Exception ex) {
                MessageBox.Show("Favor de verificar los datos. Adicional: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            bitacora.Rows.Add(particiones.ElementAt(selected.Id - 1).Trabajo, "FIN del trabajo.");
            memoriaDisponibleUsable = memoriaDisponibleUsable.sumar(particiones.ElementAt(selected.Id - 1).Trabajo.Tamanio);
            particiones.ElementAt(selected.Id - 1).quitarTrabajo();

            MessageBox.Show("Se termino el trabajo en la particion " + selected.Id);

            if(enEspera.Count > 0) { //Hay elementos en espera, intentar asignarlos.
                foreach(Trabajo t in enEspera) {
                    if(t.Tamanio.compareTo(selected.Tamanio) == -1 || t.Tamanio.compareTo(selected.Tamanio) == 0) {
                        AT(t, selected);
                        enEspera.Remove(t);
                        mostrarEnEspera();
                        break;
                    }
                }
            }

            clearItems();
            rellenarParticiones();

            //Rellenar grafica
            Unidad aux = new Unidad(grafica.Series["Partición " + selected.Id].Points[0].YValues[0] + grafica.Series["Partición " + selected.Id].Points[1].YValues[0], "MB");
            grafica.Series["Partición " + selected.Id].Points.Clear();
    //        grafica.Series["Partición " + selected.Id].Points.RemoveAt(1);

            grafica.Series["Partición " + selected.Id].Points.AddXY("Memoria", aux.obtenerMB());
         //   grafica.Series["Partición " + selected.Id].Points.AddXY("Memoria utilizada", nuevoTrabajo.Tamanio.obtenerMB());
        }

        private ParticionEstatica buscarTrabajoEnParticion(string id) {
            ParticionEstatica particion = null;

            foreach(ParticionEstatica p in particiones) {
                if(!p.IsDisponible && p.Trabajo.Id.Equals(id)) {
                    particion = p;
                    break;
                }
            }

            foreach(Trabajo t in enEspera) {
                if(t.Id.Equals(id))
                    return null;
            }

            return particion;
        }

        private void rellenarParticiones() {
            dgvParticiones.Rows.Clear();
            dgvParticiones.Rows.Add("Sistema operativo", sistemaOperativo, "0 KB", "Sistema operativo");

            foreach(ParticionEstatica p in particiones) {
                dgvParticiones.Rows.Add(p.Id, p.Tamanio, p.Tamanio.restar(p.Trabajo == null ? null : p.Trabajo.Tamanio), p.Trabajo == null ? "Sin asignar" : p.Trabajo.ToString());
            }
        }
        
        private void mostrarEnEspera() {
            dgvEspera.Rows.Clear();

            foreach(Trabajo t in enEspera)
                dgvEspera.Rows.Add(t.ToString());
        }

        private void clearItems() {
            nudTrabajo.Focus();
            cboTrabajo.SelectedIndex = 2;
            nudTrabajo.Value = 1;
            txtIdTrabajo.Text = "";
            txtIdTrabajoDesasignar.Text = "";
            nudParticion.Value = 1;
            cboParticion.SelectedIndex = 2;

            lblMemoriaTotalDisponible.Text = memoriaDisponibleUsable.ToString();
        }
    }
}
