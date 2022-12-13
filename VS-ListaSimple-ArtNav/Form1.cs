using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_ListaOrdenada_ArtNav {
    public partial class Form1 : Form {
        ListaOrdenadaSimple<FabricaArticulosNavidenios> miLista;

        public Form1() {
            InitializeComponent(); Width = 307; Height = 160;
           
            groupBox1.Visible = false; groupBox2.Visible = false;groupBox3.Visible = false; dataGridView1.Visible = false;grpInicial.Location = new Point(12,12);

            cboClasificacion.SelectedIndex = 0;
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Tamaño del territorio", "Tamaño del territorio");
            dataGridView1.Columns.Add("Clasificacion", "Clasificacion");
            dataGridView1.Columns.Add("Fecha inauguracion", "Fecha inauguracion");
            dataGridView1.Columns.Add("Tiene credito", "Tiene credito");
            dataGridView1.Columns.Add("Cantidad empleados", "Cantidad empleados");
            dataGridView1.Columns.Add("Cantidad proveedores", "Cantidad proveedores");
            dataGridView1.Columns.Add("Tipo", "Tipo"); txtNombre.Focus();
        }

        private void btnAgregarFabrica_Click(object sender, EventArgs e) {
            FabricaArticulosNavidenios miFabrica = new FabricaArticulosNavidenios();
            try {
                miFabrica.Nombre = txtNombre.Text;
                miFabrica.TamanioTerritorio = int.Parse(txtTamanio.Text);
                miFabrica.FechaInauguracion = dtmFechaInauguracion.Value;
                miFabrica.TieneCredito = chkTieneCredito.Checked;
                miFabrica.CantidadEmpleados = int.Parse(txtCantidadEmpleados.Text);
                miFabrica.CantidadProveedores = int.Parse(txtCantidadProveedores.Text);
                miFabrica.ModificarImagen(txtImagen.Text);

                switch (cboClasificacion.SelectedIndex) {
                    case 0: miFabrica.Clasificacion = 'C'; break;
                    case 1: miFabrica.Clasificacion = 'B'; break;
                    case 2: miFabrica.Clasificacion = 'A'; break;
                    case 3: miFabrica.Clasificacion = 'S'; break;
                    default: miFabrica.Clasificacion = 'C'; break;
                }

                if (radPrivada.Checked) miFabrica.TipoSegunDependencia = "Privada";
                else if (radPublica.Checked) miFabrica.TipoSegunDependencia = "Publica";
                else miFabrica.TipoSegunDependencia = "Mixta";
            }catch(Exception ex) {
                MessageBox.Show("Favor de verificar los datos de la fabrica:\n" + ex.Message); return;
            }

            MessageBox.Show(miLista.Agregar(miFabrica)?"Se agrego la nueva fabrica.":"No se agrego la fabrica.");

            Mostrar(); Acciones();
        }

        private void Mostrar() {    
            dataGridView1.Rows.Clear(); bool a = true;

            foreach (FabricaArticulosNavidenios f in miLista) {
                if (a) { try { pictureBox1.Image = Image.FromFile(f.ObtenerImagen()); a = false; } catch { pictureBox1.Image = Properties.Resources.FabricaIcono; } }
                dataGridView1.Rows.Add(f.Nombre, f.TamanioTerritorio, f.Clasificacion, f.FechaInauguracion, f.TieneCredito ? "Si" : "No",
                    f.CantidadEmpleados, f.CantidadProveedores, f.TipoSegunDependencia);         
            }
        }

        private void Acciones() {
            foreach (Control c in groupBox1.Controls) {
                if (c is TextBox)
                    c.Text = "";
            }

            txtNombre.Focus();
        }

        private void btnExaminar_Click(object sender, EventArgs e) {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "C://";
            op.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if(op.ShowDialog() == DialogResult.OK) {
                pictureBox1.ImageLocation = op.FileName;
                txtImagen.Text = op.FileName;
            } 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView1.CurrentRow == null) return;
            
            int x = dataGridView1.CurrentRow.Index; FabricaArticulosNavidenios fabricaAux = null;
            string selected = dataGridView1.Rows[x].Cells[0].Value.ToString();

            foreach(FabricaArticulosNavidenios f in miLista) {
                if (selected == f.Nombre) {
                    fabricaAux = f; break;
                }
            }

            if (fabricaAux != null) {
                string strAux = fabricaAux.ObtenerImagen(); 
                if (strAux == "")
                    pictureBox1.Image = Properties.Resources.FabricaIcono;
                else
                    pictureBox1.ImageLocation = strAux;

                txtNombre.Text = fabricaAux.Nombre;
                txtTamanio.Text = fabricaAux.TamanioTerritorio.ToString();
                switch (fabricaAux.Clasificacion) {
                    case 'C': cboClasificacion.Text = "C-Micro"; break;
                    case 'B': cboClasificacion.Text = "B-Pequeña"; break;
                    case 'A': cboClasificacion.Text = "A-Mediana"; break;
                    case 'S': cboClasificacion.Text = "S-Grande"; break;
                }
                dtmFechaInauguracion.Value = fabricaAux.FechaInauguracion;
                txtCantidadEmpleados.Text = fabricaAux.CantidadEmpleados.ToString();
                txtCantidadProveedores.Text = fabricaAux.CantidadProveedores.ToString();
                txtImagen.Text = fabricaAux.ObtenerImagen();
                if (fabricaAux.TipoSegunDependencia == "Privada") radPrivada.Checked = true;
                else if (fabricaAux.TipoSegunDependencia == "Publica") radPublica.Checked = true;
                else radMixta.Checked = true;
                chkTieneCredito.Checked = fabricaAux.TieneCredito;
            } else {
                MessageBox.Show("Error");
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta seguro que desea eliminar toda la lista?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                MessageBox.Show("Se elimino la lista.");
                miLista.Vaciar();
            } else {
                MessageBox.Show("No se elimino la lista");
            }
            Mostrar();Acciones();
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e) {
            if (dataGridView1.CurrentRow == null) { MessageBox.Show("Favor de seleccionar un elemento."); return; }

            FabricaArticulosNavidenios fabricaAux = new FabricaArticulosNavidenios();
            fabricaAux.Nombre= dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

            if (MessageBox.Show("Esta seguro que desea eliminar la fabrica:\n"+fabricaAux.Nombre, "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                fabricaAux = miLista.EliminarNodo(fabricaAux);
                string aux = fabricaAux.TieneCredito?"Si":"No";

                MessageBox.Show("Se elimino la fabrica con datos:\n"
                + "Nombre: " + fabricaAux.Nombre + "\n"
                + "Tamaño del territorio: " + fabricaAux.TamanioTerritorio + "metros cuadrados" + "\n"
                + "Clasificacion: " + fabricaAux.Clasificacion + "\n"
                + "Fecha inauguracion: " + fabricaAux.FechaInauguracion + "\n"
                + "Tiene credito: " + aux + "\n"
                + "Cantidad empleados: " + fabricaAux.CantidadEmpleados + "\n"
                + "Cantidad proveedores: " + fabricaAux.CantidadProveedores + "\n"
                + "Tipo segun su dependencia: "+fabricaAux.TipoSegunDependencia + "\n");
            } else {
                MessageBox.Show("No se elimino la fabrica.");
            }

            Mostrar();Acciones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            Acciones();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            grpInicial.Visible = false;
            groupBox1.Visible = true; groupBox2.Visible = true; groupBox3.Visible = true; dataGridView1.Visible = true;
            Width = 854;Height = 538;
            miLista = new ListaOrdenadaSimple<FabricaArticulosNavidenios>(chkOrdenar.Checked,chkDuplicados.Checked);
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            if (txtNombre.Text == "") { MessageBox.Show("Rellenar campo del nombre"); return; }

            FabricaArticulosNavidenios fabricaAux = new FabricaArticulosNavidenios() { Nombre = txtNombre.Text };

            fabricaAux = miLista.Buscar(fabricaAux);

            MessageBox.Show(fabricaAux != null ? "Se encontro la fabrica con los datos:" + fabricaAux.ToString() : "No se encontro la fabrica");

            txtNombre.Focus();
        }
    }
}
