using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimulacionParticionDeMemorias {
    public partial class MemoriaDinamica : Form {
        private Unidad memoria = new Unidad();
        private Unidad memoriaDisponibleUsable = new Unidad();
        private Unidad memoriaDisponibleDesperdiciada;
        private Unidad sistemaOperativo;
        private ArrayList trabajos = new ArrayList();
        private List<Trabajo> enEspera = new List<Trabajo>();
        private ListaDinamica lista = new ListaDinamica();

        public MemoriaDinamica() {
            InitializeComponent();
            cboSistemaOperativo.SelectedIndex = 2;
            cboMemoria.SelectedIndex = 2;
        }

        private void btnGuardarPrincipales_Click(object sender, EventArgs e) {
            #region Lectura de datos
            try {
                if(cboSistemaOperativo.Text.Equals("") || cboMemoria.Text.Equals(""))
                    throw new Exception("Se esperaba un tipo MB o GB.");

                memoria = new Unidad((double) nudMemoria.Value, cboMemoria.Text);
                sistemaOperativo = new Unidad((double) nudSistemaOperativo.Value, cboSistemaOperativo.Text);

                if(sistemaOperativo.compareTo(memoria) == 1)
                    throw new Exception("Tamaño de sistema operativo no puede ser mayor a la memoria total.");

                if(sistemaOperativo.obtenerMB() * 100 / memoria.obtenerMB() > 30)
                    throw new Exception("Tamaño de sistema operativo no puede abarcar mas del 30%.");

                lista.TamanioTotal = memoria;
                lista.agregarSO(new Trabajo(sistemaOperativo, "Sistema Operativo"));
                memoriaDisponibleDesperdiciada = memoria.restar(sistemaOperativo);
            } catch(Exception ex) {
                MessageBox.Show("Favor de verificar los datos. Adicional: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            MessageBox.Show("Datos guardados exitosamente.");
            lblMemoriaTotalDisponible.Text = lista.obtenerDisponibleParaAsignar().ToString();

            grafica.Series.Add("Sistema operativo");
            grafica.Series["Sistema operativo"].IsValueShownAsLabel = true;
            grafica.Series["Sistema operativo"].ChartType = SeriesChartType.StackedColumn;
            grafica.Series["Sistema operativo"].Points.AddXY("Memoria", sistemaOperativo.obtenerMB());
            grafica.Series.Add("Memoria sin asignar");
            grafica.Series["Memoria sin asignar"].IsValueShownAsLabel = true;
            grafica.Series["Memoria sin asignar"].ChartType = SeriesChartType.StackedColumn;
            grafica.Series["Memoria sin asignar"].Points.AddXY("Memoria", memoriaDisponibleDesperdiciada.obtenerMB());

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void btnAgregarTrabajo_Click(object sender, EventArgs e) {
            try {
                Trabajo nuevoTrabajo;

                if(cboTrabajo.Text.Equals(""))
                    throw new Exception("Se esperaba un tipo para el trabajo.");
                if(txtIdTrabajo.Text.Equals("") || txtIdTrabajo.Text.Equals("S/T") || lista.findPosition(txtIdTrabajo.Text) != -1 || isInEspera(txtIdTrabajo.Text))
                    throw new Exception("El trabajo debe contener un ID UNICO, ejemplo: T1, T2...");

                nuevoTrabajo = new Trabajo(new Unidad((double) nudTrabajo.Value, cboTrabajo.Text), txtIdTrabajo.Text);

                switch(lista.agregarTrabajo(nuevoTrabajo)) {
                    case -1:
                        MessageBox.Show("No es posible asignar el trabajo a ninguna particion. Adicional: Verifique que que el trabajo quepa en el tamaño de alguna particion.");
                        bitacora.Rows.Add(nuevoTrabajo, "NUNCA se asigna.");
                        return;
                    case 0:
                        enEspera.Add(nuevoTrabajo);
                        MessageBox.Show("Por el momento no es posible asignar el trabajo a ninguna particion, su ejecucion permanecera en espera. Adicional: Se asignara al terminar algun trabajo.");
                        bitacora.Rows.Add(nuevoTrabajo, "En ESPERA de ser atendido.");
                        mostrarEnEspera();
                        return;
                    case 1:
                        AT(nuevoTrabajo);
                        break;
                }
            } catch(Exception ex) {
                MessageBox.Show("Favor de verificar los datos. Adicional: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AT(Trabajo nuevoTrabajo) {
            bitacora.Rows.Add(nuevoTrabajo, "ASIGNADO.");

            //Memoria total
            memoriaDisponibleUsable = memoriaDisponibleUsable.restar(nuevoTrabajo.Tamanio);
            lblMemoriaTotalDisponible.Text = memoriaDisponibleUsable.ToString();

            MessageBox.Show("Trabajo asignado exitosamente.");
            clearItems();
            rellenarParticiones();

            //Alterar grafica "dividir a la mitad"
            //         Unidad aux = new Unidad(grafica.Series["Partición " + selected.Id].Points[0].YValues[0], "MB");
            //       grafica.Series["Partición " + selected.Id].Points.RemoveAt(0);
            //     grafica.Series["Partición " + selected.Id].Points.AddXY("Memoria", aux.restar(nuevoTrabajo.Tamanio).obtenerMB());
            //   grafica.Series["Partición " + selected.Id].Points.AddXY("Memoria utilizada", nuevoTrabajo.Tamanio.obtenerMB());
        }

        private void btnDesasignarTrabajo_Click(object sender, EventArgs e) {
            int pos;
            Trabajo deleted;
            try {
                if(txtIdTrabajoDesasignar.Text.Equals(""))
                    throw new Exception("Se esperaba que indicara el ID de un trabajo.");

                deleted = findWork(txtIdTrabajoDesasignar.Text);

                if(deleted == null)
                    throw new Exception("El trabajo " + txtIdTrabajoDesasignar + " no se encontro en los trabajos asignados.");

                pos = lista.quitarTrabajo(txtIdTrabajoDesasignar.Text);
            } catch(Exception ex) {
                MessageBox.Show("Favor de verificar los datos. Adicional: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //     bitacora.Rows.Add(particiones.ElementAt(selected.Id - 1).Trabajo, "FIN del trabajo.");
            //   memoriaDisponibleUsable = memoriaDisponibleUsable.sumar(particiones.ElementAt(selected.Id - 1).Trabajo.Tamanio);
            // particiones.ElementAt(selected.Id - 1).quitarTrabajo();

            MessageBox.Show("Se termino el trabajo " + txtIdTrabajoDesasignar.Text);
            TrabajoDinamico selected = (TrabajoDinamico) lista.Trabajos[pos];
            bitacora.Rows.Add(deleted, "FINALIZADO.");
            memoriaDisponibleUsable = memoriaDisponibleUsable.sumar(deleted.Tamanio);

            if(enEspera.Count > 0) { //Hay elementos en espera, intentar asignarlos.
                foreach(Trabajo t in enEspera) {
                    if(t.Tamanio.compareTo(selected.TamanioTotal) == -1 || t.Tamanio.compareTo(selected.TamanioTotal) == 0) {
                        lista.agregarTrabajo(t);
                        AT(t);
                        enEspera.Remove(t);
                        mostrarEnEspera();
                        break;
                    }
                }
            }

            clearItems();
            rellenarParticiones(); 

             /*       //Rellenar grafica
                    Unidad aux = new Unidad(grafica.Series["Partición " + selected.Id].Points[0].YValues[0] + grafica.Series["Partición " + selected.Id].Points[1].YValues[0], "MB");
                    grafica.Series["Partición " + selected.Id].Points.Clear();
            //        grafica.Series["Partición " + selected.Id].Points.RemoveAt(1);

                    grafica.Series["Partición " + selected.Id].Points.AddXY("Memoria", aux.obtenerMB());
                 //   grafica.Series["Partición " + selected.Id].Points.AddXY("Memoria utilizada", nuevoTrabajo.Tamanio.obtenerMB());*/
        }

        /*   private ParticionEstatica buscarTrabajoEnParticion(string id) {
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
           }*/

        private void rellenarParticiones() {
            dgvParticiones.Rows.Clear();

            foreach(TrabajoDinamico p in lista.Trabajos) {
                dgvParticiones.Rows.Add(p.Id, p.TamanioTotal, p.TamanioTotal.restar(p.TamanioOcupado), p.ToString());
            }
        }


        private bool isInEspera(string id) {
            foreach(Trabajo t in enEspera) {
                if(t.Id.Equals(id))
                    return true;
            }

            return false;
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

            lblMemoriaTotalDisponible.Text = memoriaDisponibleUsable.ToString();
        }

        private Trabajo findWork(string id) {
            foreach(TrabajoDinamico t in lista.Trabajos) {
                if(t.Id != null && t.Id.Equals(id))
                    return new Trabajo(t.TamanioOcupado, t.Id);
            }

            return null;
        }
    }
}
