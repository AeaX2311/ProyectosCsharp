using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vs_5._3_Ejemplos {
    public partial class Form1 : Form {
        Cliente miCliente = new Cliente();

        public Form1() {
            InitializeComponent();
            dtmFechaActual.Value = DateTime.Now;
        }

        private void BtnCalcular_Click(object sender, EventArgs e) {
            miCliente.Nombre = txtNombre.Text;
            miCliente.FechaNacimiento = dtmFechaNacimiento.Value;

            if (miCliente.EsMayorEdad())
                MessageBox.Show(miCliente.Nombre + " es mayor de edad.\n"+miCliente.CalcularEdad()+" anios.");
            else
                MessageBox.Show(miCliente.Nombre + " es menor de edad\n" + miCliente.CalcularEdad() + " anios.");
        }
    }
}
