using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_1._3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtnCalcularTiempo_Click(object sender, EventArgs e) {
            Rectangulo ventana = new Rectangulo();
            ventana.ModificarAncho(double.Parse(txtAVentana.Text));
            ventana.ModificarLargo(double.Parse(txtLVentana.Text));

            Rectangulo pared = new Rectangulo();
            pared.ModificarAncho(double.Parse(txtAPared.Text));
            pared.ModificarLargo(double.Parse(txtLPared.Text));

            MessageBox.Show("El tiempo estimado es de: " + (pared.CalcularArea() - ventana.CalcularArea()) * 10 + " minutos");


        }
    }
}
