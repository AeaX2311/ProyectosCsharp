using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vs_3._3._1 {
    public partial class Form1 : Form {
        Automovil miAuto = new Automovil();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            if (miAuto.InsertarLlanta(new Llanta("Michelin1"))) MessageBox.Show("Si");else MessageBox.Show(" No");
            if (miAuto.InsertarLlanta(new Llanta("Michelin2"))) MessageBox.Show("Si"); else MessageBox.Show(" No");
            if (miAuto.InsertarLlanta(new Llanta("Michelin3"))) MessageBox.Show("Si"); else MessageBox.Show(" No");
            if (miAuto.InsertarLlanta(new Llanta("Michelin4"))) MessageBox.Show("Si"); else MessageBox.Show(" No");
            if (miAuto.InsertarLlanta(new Llanta("Michelin5"))) MessageBox.Show("Si"); else MessageBox.Show(" No");

            foreach (Llanta l in miAuto.LlantaS)
                MessageBox.Show(l.ToString());


            miAuto.InsertarPuerta(new Puerta("X"));


            foreach (Puerta l in miAuto)
                MessageBox.Show(l.ToString());
        }
    }
}
