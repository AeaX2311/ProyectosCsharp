using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_EjemploRestriccionTipos {
    public partial class Form1 : Form {
        private MotocicletaRepartidora<Alimento> miMotocicletaRepartidora = new MotocicletaRepartidora<Alimento>();
        public Form1() {
            InitializeComponent();

            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Direccion", "Direccion");
            dataGridView1.Columns.Add("Distancia","Distancia");
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnOrdenar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            Alimento nuevoAlimento = new Alimento();

            if (txtNombre.Text == "" || txtDireccion.Text == "") {
                MessageBox.Show("No se rellenaron todos los campos", "Error");
                txtDireccion.Text = "";
                txtDistancia.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtNombre.Focus();
                return;
            }

            nuevoAlimento.Nombre = txtNombre.Text;
            nuevoAlimento.Direccion = txtDireccion.Text;
            try {
                nuevoAlimento.Precio = double.Parse(txtPrecio.Text);
                nuevoAlimento.Distancia = int.Parse(txtDistancia.Text);
            }catch{
                MessageBox.Show("Formato incorrecto", "Error");
                return;
            } finally {
                txtDireccion.Text = "";
                txtDistancia.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtNombre.Focus();
            }

            CajaAlimento<Alimento> nuevaCaja = new CajaAlimento<Alimento>();
            nuevaCaja.InsertarAlimento(nuevoAlimento);

            miMotocicletaRepartidora.InsertarCaja(nuevaCaja);

            MessageBox.Show("Se agrego la caja con el nuevo pedido de alimento.");
            btnOrdenar.Enabled = true; Mostrar();
        }

        public void Mostrar() {
            dataGridView1.Rows.Clear();

            foreach(CajaAlimento<Alimento> c in miMotocicletaRepartidora) {
                dataGridView1.Rows.Add(c.ConsultarAlimento().Nombre, c.ConsultarAlimento().Precio.ToString("C"),
                    c.ConsultarAlimento().Direccion, c.ConsultarAlimento().Distancia+" m");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e) {
            miMotocicletaRepartidora.OrdenarCajas();
            MessageBox.Show("Se ordenaron los pedidos de mayor a menor segun la distancia en metros hacia el destino");
            Mostrar();
        }
    }
}
