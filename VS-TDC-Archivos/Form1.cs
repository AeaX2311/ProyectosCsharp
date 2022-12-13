using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchivoBinario;

namespace VS_TDC.Archivos {
    public partial class Form1 : Form {
        ArchivoSecuencialSerializadoBinario<VitroPiso> miArchivo = new ArchivoSecuencialSerializadoBinario<VitroPiso>("C:\\Datos\\Archivo.dat");
        public Form1() {
            InitializeComponent();

            dataGridView1.Columns.Add("Marca", "Marca");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Color", "Color");
            dataGridView1.Columns.Add("Largo", "Largo");
            dataGridView1.Columns.Add("Ancho", "Ancho");
            dataGridView1.Columns.Add("Espesor", "Espesor");
            dataGridView1.Columns.Add("Mayoreo", "Mayoreo");
            dataGridView1.Columns.Add("Clidad", "Calidad");
            dataGridView1.Columns.Add("Piezas por paquete", "Piezas por paquete");
            dataGridView1.Columns.Add("Fecha de registro", "Fecha de registro");
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Mostrar(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            VitroPiso unVitroPiso = new VitroPiso();

            try {
                unVitroPiso.Marca = txtMarca.Text;
                unVitroPiso.Precio = double.Parse(txtPrecio.Text);
                unVitroPiso.Color = txtColor.Text;
                unVitroPiso.Largo = double.Parse(txtLargo.Text);
                unVitroPiso.Ancho = double.Parse(txtAncho.Text);
                unVitroPiso.Espesor = double.Parse(txtEspesor.Text);
                unVitroPiso.VentaPorMayoreo = radSi.Checked;
                unVitroPiso.Calidad = 'S';

                if (cboCalidad.SelectedIndex == 1) unVitroPiso.Calidad = 'A'; else if (cboCalidad.SelectedIndex == 2) unVitroPiso.Calidad = 'B';

                unVitroPiso.CantidadPiezasPorPaquete = int.Parse(txtCantidadPiezasPorPaquete.Text);
                unVitroPiso.FechaRegistro = dtmFechaRegistro.Value;

            }catch(Exception ex) {
                MessageBox.Show("Favor de verificar los datos:\n"+ex.Message); Limpiar();
                return;
            }

            try {
                miArchivo.AbrirModoEscritura();
                miArchivo.GrabarObjeto(unVitroPiso);

                MessageBox.Show("Se agrego el nuevo vitropiso");
            } catch (Exception ex) {
                MessageBox.Show("No se agrego el vitropiso:\n" + ex.Message);
                return;
            } finally {
                miArchivo.Cerrar();
            }
             
            Limpiar(); Mostrar();
        }

        private void Mostrar() {
            VitroPiso miVitroPiso;  dataGridView1.Rows.Clear();

            bool blnExiste = miArchivo.AbiriModoLectura();

            if (blnExiste) {
                while (true) {
                    try { miVitroPiso = miArchivo.LeerOjeto(); } catch { break; }

                    dataGridView1.Rows.Add(miVitroPiso.Marca, miVitroPiso.Precio, miVitroPiso.Color, miVitroPiso.Largo + " cm",
                    miVitroPiso.Ancho + " cm", miVitroPiso.Espesor + " cm", miVitroPiso.VentaPorMayoreo ? "Si" : "No",
                    miVitroPiso.Calidad, miVitroPiso.CantidadPiezasPorPaquete, miVitroPiso.FechaRegistro);
                }
                miArchivo.Cerrar();
            }
        }

        private void Limpiar() {
            txtMarca.Focus();
            foreach (Control c in groupBox1.Controls)
                if (c is TextBox)
                    c.Text = "";
        }

        private void btnVaciarLista_Click(object sender, EventArgs e) {
            if (miArchivo.Existe()) {
                if (MessageBox.Show("Esta seguro que desea eliminar todos los datos?", "Confirmacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    try {
                        miArchivo.EliminarArchivo();
                    } catch (Exception ex) {
                        MessageBox.Show("No se borraron los datos:\n" + ex.Message); return;
                    }

                    MessageBox.Show("Se borraron todos los datos.");
                    Mostrar();
                }
            } else 
                MessageBox.Show("No hay nada que eliminar.");
        }


        private void Mostrarr() {
            miArchivo.AbiriModoLectura(); listBox1.Items.Clear();
            VitroPiso miVitroPiso;
            while (true) {
                try { miVitroPiso = miArchivo.LeerOjeto(); } catch { break; }

                if (miVitroPiso.Largo > 9 && miVitroPiso.Largo < 51) {
                    listBox1.Items.Add(miVitroPiso.Largo);
                }
            }

            miArchivo.Cerrar();
        }

        private void button1_Click(object sender, EventArgs e) {
            Mostrarr();
        }
    }
}
