using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_ExamenABBPractico {
    public partial class Form1 : Form {
        ArbolBinarioDeBusqueda<Celular> miArbol = new ArbolBinarioDeBusqueda<Celular>(); 
        Random intRand = new Random();

        public Form1() {
            InitializeComponent();
            dataGridView1.Columns.Add("Clave unica", "Clave unica");
            dataGridView1.Columns.Add("Modelo", "Modelo");
            dataGridView1.Columns.Add("Costo", "Costo");
            dataGridView2.Columns.Add("Clave unica", "Clave unica");
            dataGridView2.Columns.Add("Modelo", "Modelo");
            dataGridView2.Columns.Add("Costo", "Costo");
        }

        private void Mostrar() {
            dataGridView1.Rows.Clear();

            if (radPostOrden.Checked) {
                foreach (Celular c in miArbol.RecorrerPostOrden()) {
                    dataGridView1.Rows.Add(c.ClaveUnica, c.Modelo, c.Costo);
                }
            } else if (radInOrden.Checked) {
                foreach (Celular c in miArbol.RecorrerInOrden()) {
                    dataGridView1.Rows.Add(c.ClaveUnica, c.Modelo, c.Costo);
                }
            } else {
                foreach (Celular c in miArbol.RecorrerPreOrden()) {
                    dataGridView1.Rows.Add(c.ClaveUnica, c.Modelo, c.Costo);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {/*
            if (dataGridView1.CurrentRow == null) return;

            int x = dataGridView1.CurrentRow.Index; FabricaArticulosNavidenios fabricaAux = null;
            string selected = dataGridView1.Rows[x].Cells[0].Value.ToString();

            foreach (FabricaArticulosNavidenios f in miArbol.RecorrerInOrden()) {
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
            }*/
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta seguro que desea eliminar toda la lista?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                MessageBox.Show("Se eliminaron todas las fabricas.");
                miArbol.Vaciar();
            } else {
                MessageBox.Show("No se elimino la lista");
            }
            Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            if (txtClaveUnica.Text == "") { MessageBox.Show("Rellenar campo de la clave unica"); return; }

            Celular celularAux = new Celular() { ClaveUnica = int.Parse(txtClaveUnica.Text) };

            celularAux = miArbol.Buscar(celularAux);

            if (celularAux != null) {
                string strCelular = "Clave unica: " + celularAux.ClaveUnica + "\n"
                + "Modelo: " + celularAux.Modelo + "\n"
                + "Costo: " + celularAux.Costo.ToString("C");

                MessageBox.Show("Se encontro el celular con los datos:" + strCelular);
            } else
                MessageBox.Show("No se encontro el celular");
        }

        private void btnEliminarSeleccionado_Click_1(object sender, EventArgs e) {
            if (dataGridView1.CurrentRow == null) { MessageBox.Show("Favor de seleccionar un elemento."); return; }

            Celular celularAux = new Celular();
            celularAux.ClaveUnica = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

            if (MessageBox.Show("Esta seguro que desea eliminar el celular con clave:\n" + celularAux.ClaveUnica, "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                celularAux = miArbol.Eliminar(celularAux);

                MessageBox.Show("Se elimino el celular con datos:\n"
                + "Clave unica: " + celularAux.ClaveUnica + "\n"
                + "Modelo: " + celularAux.Modelo + "\n"
                + "Costo: " + celularAux.Costo.ToString("C"));
            } else {
                MessageBox.Show("No se elimino el celular.");
            }

            Mostrar();
        }

        private void btnGenerarAleatorio_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Se eliminara cualquier elemento generado anteriormente, desea continuar?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                Celular miCelular; miArbol.Vaciar();

                for (int x = 0; x < 10; x++) {
                    miCelular = new Celular();

                    miCelular.ClaveUnica = intRand.Next(0, 10000000);
                    miCelular.Modelo = GenerarModeloAleatorio();
                    miCelular.Costo = intRand.NextDouble() * (30001 - 1000) + 1000;
                    miArbol.Insertar(miCelular);
                }

                MessageBox.Show("Se generaron 10 celulares con datos aleatorios.");
            } else {
                MessageBox.Show("No se generaron celulares aleatorias.");
            }
            Mostrar();
        }

        private string GenerarModeloAleatorio() {
            string strPosibles = "ABCDEFGHIJKLMNOPQRSTUVWXYZ", strNombre="CEL-";

            for(int x = 0; x < 10; x++) 
                strNombre += strPosibles[intRand.Next(0, 26)];

            return strNombre;
        }

        private void picArbol_Click(object sender, EventArgs e) {
            if (picArbol.Image != null) {
                CrearFormaConFigura(picArbol.Image);
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e) {
            if (miArbol.Vacio) {
                MessageBox.Show("No hay ninguna fabrica en estos momentos"); return;
            }

            Dibujar();
        }

        private void Dibujar() {
            GenerarCodigoFigura();

            try {
                System.Diagnostics.Process.Start(RutasDeAcceso.Bat);

                Thread.Sleep(600);

                System.IO.FileStream miArchivo = new System.IO.FileStream(RutasDeAcceso.FiguraJpg, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                picArbol.Image = Image.FromStream(miArchivo); miArchivo.Close();
            } catch (Exception ex) {
                MessageBox.Show("Error bat: \n" + ex.Message);
            }
            picArbol.Refresh();
        }

        private void CrearFormaConFigura(Image img) {
            Form frmVentana = new Form();
            frmVentana.Width = 1400; frmVentana.Height = 1000;
            frmVentana.AutoScroll = true; frmVentana.Text = "Figura";
            frmVentana.StartPosition = FormStartPosition.CenterScreen;
            frmVentana.Show();

            PictureBox picABB = new PictureBox();
            picABB.Parent = frmVentana; picABB.Width = 990; picABB.Height = 565;
            picABB.SizeMode = PictureBoxSizeMode.Zoom;

            picABB.Image = img;
            picABB.Refresh();
        }

        private void GenerarCodigoFigura() {
            string strCodigoEnDOT = miArbol.GenerarCodigoDOT();

            try {
                System.IO.StreamWriter miArchivo = new System.IO.StreamWriter(RutasDeAcceso.FiguraSinExtension);
                miArchivo.WriteLine(strCodigoEnDOT);
                miArchivo.Close();
            } catch (Exception ex) {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void radPreOrden_CheckedChanged(object sender, EventArgs e) {
            Mostrar();
        }

        private void radInOrden_CheckedChanged(object sender, EventArgs e) {
            Mostrar();
        }

        private void radPostOrden_CheckedChanged(object sender, EventArgs e) {
            Mostrar();
        }
        private void btnActualizar_Click(object sender, EventArgs e) {
            Mostrar(); Dibujar();
        }

        private void btnCambiar_Click(object sender, EventArgs e) {
            Hide();
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btnProblema_Click(object sender, EventArgs e) {
            if (dataGridView1.CurrentRow == null) { MessageBox.Show("Favor de seleccionar un elemento."); return; }

            Celular celularAux = new Celular();
            celularAux.ClaveUnica = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            Nodo<Celular> miNodo = new Nodo<Celular>(celularAux);


            dataGridView2.Rows.Clear();
            foreach (Nodo<Celular> nodo in miArbol.DevolverNodosMayores(miNodo)) {
                Celular c = nodo.ObjetoConDatos;    
                dataGridView2.Rows.Add(c.ClaveUnica, c.Modelo, c.Costo);
            }

            MessageBox.Show("Se mostraron los datos en el visor de la derecha");
            Mostrar();
        }
    }
}
