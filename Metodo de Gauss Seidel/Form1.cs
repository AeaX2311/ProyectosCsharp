using System;
using System.Windows.Forms;

namespace Metodo_de_Gauss_Seidel {
    public partial class Form1 : Form {
        public double[,] misValores = new double[50, 3];
        public double[,] misErrores = new double[50, 3];
        public double errorPermitido;

        public Form1() {
            InitializeComponent(); txtValor1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            calcularMetodoGaussSeidel();
        }

        public void calcularMetodoGaussSeidel() {
            try {
                misValores[0, 0] = double.Parse(txtValor1.Text);
                misValores[0, 1] = double.Parse(txtValor2.Text);
                misValores[0, 2] = double.Parse(txtValor3.Text);
                errorPermitido = double.Parse(txtErrorPermitido.Text);
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }

            bool condicion = true; int x = 0;

            for (; condicion && x < 49; x++) {
                misValores[x + 1, 0] = evaluarDespejeFuncion1(misValores[x, 1], misValores[x, 2]);
                misValores[x + 1, 1] = evaluarDespejeFuncion2(misValores[x + 1, 0], misValores[x, 2]);
                misValores[x + 1, 2] = evaluarDespejeFuncion3(misValores[x + 1, 0], misValores[x + 1, 1]);

                ObtenerErrores(x);
                
                condicion = !(misErrores[x, 0] <= errorPermitido &&
                            misErrores[x, 1] <= errorPermitido &&
                            misErrores[x, 2] <= errorPermitido);
            }

            misErrores[0, 0] = misErrores[0, 1] = misErrores[0, 2] = 0;
            ObtenerErrores(x); mostrar(x);
            label5.Text = "Los valores obtenidos en base al criterio permitido de " + errorPermitido
                + "% es de:\n\nx1: " + misValores[x - 1, 0]
                + "\nx2: " + misValores[x - 1, 1]
                + "\nx3: " + misValores[x - 1, 2]
                + "\n\nRealizado en " + (x - 1) + " iteraciones.";
     
        }

        public void ObtenerErrores(int x) {
            for (int y = 0; y < 3; y++) misErrores[x, y] = (x > 0 && x != 1) ? determinarPorcentajeError(misValores[x, y], misValores[x - 1, y]) : 100;
        }


        public void mostrar(int x) {
            datos.Rows.Clear();
            
            //Borrar linea 61 si los valores iniciales son distintos de 0
            datos.Rows.Add("0", "0", "0", "0", "0", "0", "0");
            
            for (int i = 0; i < x; i++) {
                if ((misValores[i, 0] != 0 || misValores[i, 1] != 0 || misValores[i, 2] != 0))
                    datos.Rows.Add(i, misValores[i, 0], misErrores[i, 0].ToString("N4") + "%", misValores[i, 1], misErrores[i, 1].ToString("N4") + "%", misValores[i, 2], misErrores[i, 2].ToString("N4") + "%");
            }
        }

        public double determinarPorcentajeError(double valorActual, double valorAnterior) {
            return Math.Abs((valorActual - valorAnterior) / valorActual) * 100;
        }

        public double evaluarDespejeFuncion1(double x2, double x3) {
            return (3 + x2 + x3) / 6;
        }

        public double evaluarDespejeFuncion2(double x1, double x3) {
            return (40 - 6 * x1 - x3) / 9;
        }

        public double evaluarDespejeFuncion3(double x1, double x2) {
            return (50 + 3 * x1 - x2) / -12;
        }
    }
}
