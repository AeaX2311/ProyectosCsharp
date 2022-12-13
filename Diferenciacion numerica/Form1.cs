using System;
using System.Windows.Forms;

namespace Diferenciacion_numerica {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent(); txtValorX.Focus(); IL();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            EfectuarDerivacionNumerica(); 
        }

        public void EfectuarDerivacionNumerica() {
            double valorParaX = 0;
            double valorParaH = 0;

            try {
                valorParaX = double.Parse(txtValorX.Text);
                valorParaH = double.Parse(txtValorH.Text);
            } catch {
                MessageBox.Show("Ingresar bien los datos."); return;
            } finally {
                IL();
            }

            lblAtras.Text += ObtenerPDAtras(valorParaX, valorParaH).ToString();
            lblCentro.Text += ObtenerPDCentro(valorParaX, valorParaH).ToString();
            lblAdelante.Text += ObtenerPDAdelante(valorParaX, valorParaH).ToString();
        }

        public double EvaluarFuncionOriginal(double x) {
            return Math.Pow(Math.E, x) - 2 * x * x + 3 * x - 1;
        }

        public double ObtenerPDAdelante(double x, double h) {
            return (-EvaluarFuncionOriginal(x + 2 * h) + 4 * EvaluarFuncionOriginal(x + h) - 3 * EvaluarFuncionOriginal(x)) / (2 * h);
        }

        public double ObtenerPDAtras(double x, double h) {
            return (3 * EvaluarFuncionOriginal(x) - 4 * EvaluarFuncionOriginal(x - h) + EvaluarFuncionOriginal(x - 2 * h)) / (2 * h);
        }

        public double ObtenerPDCentro(double x, double h) {
            return (-EvaluarFuncionOriginal(x + 2 * h) + 8 * EvaluarFuncionOriginal(x + h) - 8 * EvaluarFuncionOriginal(x - h) + EvaluarFuncionOriginal(x - 2 * h)) / (12 * h);
        }

        public void IL() {
            lblAtras.Text = "f '(xi) = ";
            lblCentro.Text = "f '(xi) = ";
            lblAdelante.Text = "f '(xi) = ";
        }

        private void ver_Click(object sender, EventArgs e) {
            MessageBox.Show("Atras: " + lblAtras.Text + "\nCentro: " + lblCentro.Text + "\nAdelante: " + lblAdelante.Text);
        }
    }
}
