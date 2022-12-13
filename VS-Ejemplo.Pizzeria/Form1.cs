using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_Ejemplo.Pizzeria {
    public partial class Form1 : Form {
        private static List<Pizza> ListaOrdenes = new List<Pizza>();

        public Form1() {
            InitializeComponent();

            dataGridView1.Columns.Add("Número de orden", "Número de orden");
            dataGridView1.Columns.Add("Tamaño", "Tamaño");
            dataGridView1.Columns.Add("Can. Ingredientes", "Can. Ingredientes");

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MostrarDatos() {
            dataGridView1.Rows.Clear(); int intContador = 1;
            foreach (Pizza miPizza in ListaOrdenes) {
                dataGridView1.Rows.Add(intContador,miPizza.Tamanio,miPizza.CantidadIngredientes);
                intContador++;
            }
        }

        private void BtnOrdenar_Click(object sender, EventArgs e) {
            Pizza miPizza = new Pizza();
            miPizza.CantidadIngredientes = int.Parse(txtCantidadIngredientes.Text);
            miPizza.Tamanio = txtTamanio.Text;

            ListaOrdenes.Add(miPizza);

            MessageBox.Show("Se agrego la nueva orden");

            foreach (Control control in groupBox1.Controls)
                if (control is TextBox)
                    control.Text = "";

            MostrarDatos();
        }
    }
}
