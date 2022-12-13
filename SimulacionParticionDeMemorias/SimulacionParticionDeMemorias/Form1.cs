using System;
using System.Windows.Forms;

namespace SimulacionParticionDeMemorias {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnO1_Click(object sender, EventArgs e) {
            Form f = new MemoriaEstatica();
            f.Show();
            Hide();
        }

        private void btnMemoriaDinamica_Click(object sender, EventArgs e) {
            Form f = new MemoriaDinamica();
            f.Show();
            Hide();
        }
    }
}
