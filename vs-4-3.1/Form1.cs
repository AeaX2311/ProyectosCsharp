using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vs_4._3._1 {
    public partial class Form1 : Form {
        Colonia miColonia;
        public Form1() {
            InitializeComponent();
            dataGridView1.Columns.Add("Propietario", "Propietario");
            dataGridView1.Columns.Add("Numero", "Numero");
            dataGridView1.Columns.Add("Cant. habitaciones", "Cant. habitaciones");
            dataGridView1.Columns.Add("Fecha registro", "Fecha registro");
            dataGridView1.Columns.Add("Tamaño", "Tamaño");
            dataGridView1.Columns.Add("Dos pisos", "Dos pisos");

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Acciones(0, 1); Acciones(0, 2);
        }

        private void Acciones(int n, int m) {
            GroupBox auxg; //n = Ocultar 0 Mostrar 1 Limpiar 2

            if (m == 0) auxg = groupBox1;
            else if (m == 1) auxg = groupBox2;
            else auxg = groupBox3;

            foreach (Control c in auxg.Controls) {
                if (n == 0)
                    c.Enabled = false;
                else
                    c.Enabled = true;
            }
        }

        private void Mostrar() {
            dataGridView1.Rows.Clear();
            foreach(Hogar h in miColonia) {
                dataGridView1.Rows.Add(h.Propietario,h.NumeroExterior,h.NumeroHabitaciones,h.FechaRegistro,h.Tamanio,h.EsDosPisos);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            char chrAux = 'N';

            if (cboUbicacion.SelectedIndex == 1) chrAux = 'E';
            if (cboUbicacion.SelectedIndex == 2) chrAux = 'S';
            if (cboUbicacion.SelectedIndex == 3) chrAux = 'O';

            miColonia = new Colonia(txtNombre.Text, chrAux);
            MessageBox.Show("Se guardaron los datos de la colonia");
            Acciones(0, 0); Acciones(1, 2); txtPropietario.Focus();
        }

        private void BtnHogar_Click(object sender, EventArgs e) {
            Hogar nuevoHogar = new Hogar();

            int intAux = int.Parse(cboHabitaciones.SelectedItem.ToString());

            char chrAux = 'C';
            if (radioButton5.Checked) chrAux = 'M';
            if (radioButton4.Checked) chrAux = 'G';

            bool blnAux = false;
            if (chkDosPisos.Checked) blnAux = true;

            nuevoHogar.Propietario = txtPropietario.Text;
            nuevoHogar.FechaRegistro = dateTimePicker2.Value;
            nuevoHogar.NumeroExterior = txtNumeroExterior.Text;
            nuevoHogar.NumeroHabitaciones = intAux;
            nuevoHogar.Tamanio = chrAux;
            nuevoHogar.EsDosPisos = blnAux;

            miColonia.InsertarHogar(nuevoHogar);
            MessageBox.Show("Se han insertado los datos del nuevo hogar");

            Mostrar(); txtPropietario.Text = ""; txtNumeroExterior.Text = "";
            txtPropietario.Focus(); cboHabitaciones.Text = "1";
            radioButton6.Checked = true; chkDosPisos.Checked = false;

            Acciones(1, 1);
        }

        private void BtnA1_Click(object sender, EventArgs e) {
            MessageBox.Show("La cantidad de hogares registrados es de: " + miColonia.ContarHogares());
        }

        private void BtnA2_Click(object sender, EventArgs e) {
            MessageBox.Show("La cantidad de habitaciones que hay en total es de: " + miColonia.ContarHabitaciones());
        }
    }
}
