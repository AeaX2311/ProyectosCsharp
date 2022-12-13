using System;
using System.Windows.Forms;

namespace Integracion_Numerica {
    public partial class Form1 : Form {
        private double valorA = 0;
        private double valorB = 0;
        private double valorAnalitico;
        private double valorI;

        public Form1() {
            InitializeComponent();txtValorA.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            LeerVariables();

            if (radT.Checked) EvaluarTrapecio();
            else if (radTn2.Checked) EvaluarTrapecioN2();
            else if (radS.Checked) EvaluarSimpson13();
            else if (radSn4.Checked) EvaluarSimpson13N4();
            else EvaluarSimpson38();

            lblResultado.Text = "I = " + valorI.ToString();
            lblError.Text = ObtenerErrorRelativoPorcentual(valorI) + "%";
        }

        public double EvaluarFuncionOriginal(double x) {
            return 1 - Math.Pow(Math.E, -2 * x);
        }

        public double ObtenerErrorRelativoPorcentual(double valor) {
            return Math.Abs((valorAnalitico - valor) / valorAnalitico) * 100;
        }
        public void EvaluarTrapecio() {
            valorI = (valorB - valorA) * ((EvaluarFuncionOriginal(valorA) + EvaluarFuncionOriginal(valorB)) / 2);
        } 

        public void EvaluarTrapecioN2() {
            double valorH = ObtenerValorH(2),
                   x0 = valorA, 
                   x1 = x0 + valorH, 
                   x2 = x1 + valorH;

            valorI = (valorB - valorA) * ((EvaluarFuncionOriginal(x0) + 2 * EvaluarFuncionOriginal(x1) + EvaluarFuncionOriginal(x2)) / 4);
        }

        public void EvaluarSimpson13() {
            double x0 = valorA, 
                   x1 = (valorA + valorB) / 2, 
                   x2 = valorB;
            valorI = (valorB - valorA) * (EvaluarFuncionOriginal(x0) + 4 * EvaluarFuncionOriginal(x1) + EvaluarFuncionOriginal(x2)) / 6;
        }

        public void EvaluarSimpson13N4() {
            double valorH = ObtenerValorH(4),
                   x0 = valorA,
                   x1 = x0 + valorH,
                   x2 = x1 + valorH,
                   x3 = x2 + valorH,
                   x4 = x3 + valorH;

            valorI = (valorB - valorA) * ((EvaluarFuncionOriginal(x0) + 4 * (EvaluarFuncionOriginal(x1) 
                + EvaluarFuncionOriginal(x3)) + 2 * EvaluarFuncionOriginal(x2) + EvaluarFuncionOriginal(x4)) / 12);
        }

        public void EvaluarSimpson38() {
            double valorH = ObtenerValorH(3),
                   x0 = valorA,
                   x1 = x0 + valorH,
                   x2 = x1 + valorH,
                   x3 = x2 + valorH;

            valorI = (valorB - valorA) * ((EvaluarFuncionOriginal(x0) + 3 * EvaluarFuncionOriginal(x1) 
                + 3 * EvaluarFuncionOriginal(x2) + EvaluarFuncionOriginal(x3)) / 8);
        }

        private void LeerVariables() {
            try {
                valorA = double.Parse(txtValorA.Text);
                valorB = double.Parse(txtValorB.Text);
                valorAnalitico = double.Parse(txtValorAnalitico.Text);
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private double ObtenerValorH(int n) {
            return (valorB - valorA) / n;
        }
       
        private void radT_CheckedChanged(object sender, EventArgs e) {
            Limpiar();
        }
        private void radTn2_CheckedChanged(object sender, EventArgs e) {
            Limpiar();
        }
        private void radS_CheckedChanged(object sender, EventArgs e) {
            Limpiar();
        }
        private void radSn4_CheckedChanged(object sender, EventArgs e) {
            Limpiar();
        }
        private void radS38_CheckedChanged(object sender, EventArgs e) {
            Limpiar();
        }      
        private void Limpiar() {
            lblError.Text = ""; lblResultado.Text = "";
        }
    }
}
