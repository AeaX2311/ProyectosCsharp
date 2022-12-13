using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_PracticaPolimorfismo {
    public partial class Form1 : Form {
        Piramide auxPiramide;
        public Form1() {
            InitializeComponent();

            listBox2.Visible = false;
        }

        private void btnAgregarPiramide_Click(object sender, EventArgs e) {
            Piramide unaPiramide = new Piramide();

            try {
                unaPiramide.Nombre = txtNombre.Text;
                unaPiramide.CostoProduccion = double.Parse(txtCostoProduccion.Text);
            }catch {
                MessageBox.Show("Favor de rellenar los campos vacios","Error");
                return;
            }

            listBox1.Items.Add(unaPiramide);
            txtCostoProduccion.Text = "";
            txtNombre.Text = "";
            txtNombre.Focus();

            listBox2.Visible = false; btnCalcularPrecio.Enabled = true;
        }

        private void ctnCalcularPrecio_Click(object sender, EventArgs e) {
            Piramide unaPiramide = (Piramide)listBox1.SelectedItem;
            if (unaPiramide == null) {
                MessageBox.Show("Favor de seleccionar un elemento", "Error"); return;
            }

            MessageBox.Show("El precio final de la piramide \""+unaPiramide.Nombre+"\" es:\n"+unaPiramide.CalcularPrecio().ToString("C"));

            txtNombre.Focus();
        }

        private void btnIgualar_Click(object sender, EventArgs e) {
            auxPiramide = (Piramide)listBox1.SelectedItem;
            if (auxPiramide == null) {
                MessageBox.Show("Favor de seleccionar un elemento", "Error"); return;
            }else if (listBox1.Items.Count == 1) {
                MessageBox.Show("Solo existe un elemento, no se puede comparar", "Error"); return;
            }

            listBox1.SelectedItem = null; listBox2.Items.Clear();

            foreach (Piramide p in listBox1.Items) {
         //       if(!(p.Nombre==auxPiramide.Nombre))
                    listBox2.Items.Add(p);
            }
       
            listBox2.Visible = true; btnCalcularPrecio.Enabled = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {
            Piramide otraPiramide = (Piramide)listBox2.SelectedItem;
            if (otraPiramide == null) {
                MessageBox.Show("Favor de seleccionar un elemento", "Error");
            } else {
                if (auxPiramide.Equals(otraPiramide))
                    MessageBox.Show("La piramide " + auxPiramide.Nombre + " es IGUAL a la piramide " + otraPiramide.Nombre);
                else
                    MessageBox.Show("La piramide " + auxPiramide.Nombre + " es DIFERENTE a la piramide " + otraPiramide.Nombre);
            }

            listBox2.Visible = false; btnCalcularPrecio.Enabled = true;
        }
    }
}
