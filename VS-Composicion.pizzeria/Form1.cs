using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_Composicion.pizzeria {
    public partial class Form1 : Form {
        //Alan Abiud Castro Cruz 19100159

        Pizzeria miPizzeria; int intNumeroOrden = 1;

        public Form1() {
            InitializeComponent();

            if ('a' < 'b') MessageBox.Show("AAAAAAAAAAAA");


            dataGridView1.Columns.Add("Número orden", "Número orden");
            dataGridView1.Columns.Add("Tamaño", "Tamaño");
            dataGridView1.Columns.Add("Ingredientes", "Ingredientes");
            dataGridView1.Columns.Add("Pagada", "Pagada");
            dataGridView1.Columns.Add("Fecha entrega", "Fecha entrega");
            
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Acciones(0, 1); Acciones(0, 2);
        }

        private void BtnDatosPizzeria_Click(object sender, EventArgs e) {
            miPizzeria = new Pizzeria(txtNombre.Text, txtTelefono.Text);

            MessageBox.Show("Se registraron los datos de la pizzeria");
            Acciones(0, 0); Acciones(1, 1);
        }

        private void Acciones(int n, int m) {
            GroupBox auxg; //n = Ocultar 0 Mostrar 1 Limpiar 2

            if (m == 0) auxg = groupBox1;
            else if (m == 1) auxg = groupBox2;
            else  auxg = groupBox3;

            foreach(Control c in auxg.Controls) {
                if (n == 0)
                    c.Enabled = false;
                else
                    c.Enabled = true;
            }
        }

        private void Mostrar() {
            dataGridView1.Rows.Clear();

            foreach(Orden o in miPizzeria) {
                dataGridView1.Rows.Add(o.NumeroOrden,o.TipoPizza.Tamanio,o.TipoPizza.Ingredientes,o.Pagada?"SI":"NO",o.FechaEntrega);
            }
        }

        private void BtnOrdenar_Click(object sender, EventArgs e) {
            Orden nuevaOrden = new Orden(intNumeroOrden); intNumeroOrden++;

            nuevaOrden.FechaEntrega = dtmFechaEntrega.Value;
            nuevaOrden.Pagada = false;  char chrTamanio= 'C'; string strIngredientes;

            if (radPepperoni.Checked) strIngredientes = "Pepperoni";
            else strIngredientes = "Queso";

            foreach(Control c in groupBox2.Controls) {
                if (c is CheckBox) {
                    CheckBox d = (CheckBox)c;
                    if (d.Checked)
                        strIngredientes += ", " + c.Text;
                }
            }

            if (cboTamanio.SelectedIndex.ToString() == "1") chrTamanio = 'M';
            else if (cboTamanio.SelectedIndex.ToString() == "2") chrTamanio = 'G';

            nuevaOrden.TipoPizza = new Pizza() { Ingredientes = strIngredientes , Tamanio = chrTamanio};

            miPizzeria.NuevaOrden(nuevaOrden);

            MessageBox.Show("Se agrego la nueva orden"); Mostrar();

            Acciones(1, 2);
        }

        private void BtnPagar_Click(object sender, EventArgs e) {
            if (dataGridView1.CurrentRow == null) {
                MessageBox.Show("Seleccione una orden por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            Orden auxOrden = new Orden(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            MessageBox.Show("Se ha pagado la orden con numero: " + auxOrden.NumeroOrden);

            miPizzeria.PagarOrden(auxOrden);
            Mostrar();
        }

        private void BtnContar_Click(object sender, EventArgs e) {
            MessageBox.Show("En total se ha(n) realizado " + miPizzeria.ContarOrdenes() + " pedido(s) en el dia de hoy.");
        }

        private void BtnEliminarOrden_Click(object sender, EventArgs e) {
            if (dataGridView1.CurrentRow == null) {
                MessageBox.Show("Seleccione una orden por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            Orden auxOrden = new Orden(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            string strRespuesta = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            _ = strRespuesta == "SI" ? auxOrden.Pagada = true : auxOrden.Pagada = false;

            string strAux = "Esta seguro que desea cancelar la orden?";
            if (auxOrden.Pagada) strAux = "Esta orden YA esta pagada, Esta seguro que desea cancelar?";

            DialogResult dialogResult = MessageBox.Show(strAux, "Confirmacion", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) {
                MessageBox.Show("Se ha cancelado la orden con numero: " + auxOrden.NumeroOrden);
                miPizzeria.EliminarOrden(auxOrden);
            }

            Mostrar();
        }
    }
}
