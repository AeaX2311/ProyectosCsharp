using System;
using System.Windows.Forms;

namespace Metodo_de_Newton_Raphson {
    public partial class Form1 : Form {
        public class Valores {
            public double u;
            public double v;
            public double dudx;
            public double dudy;
            public double dvdx;
            public double dvdy;
            public double xant;
            public double yant;
            public double x;
            public double y;
        }

        private Valores[] misValores = new Valores[20];
        private int iteraciones;

        public Form1() {
            InitializeComponent(); txtValorX.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            CalcularMetodoNewtonRaphson();
        }

        public void CalcularMetodoNewtonRaphson() {
            double xantaux = 0, yantaux = 0; Valores valorAux = new Valores();
            try {
                xantaux = double.Parse(txtValorX.Text);
                yantaux = double.Parse(txtValorY.Text);
                iteraciones = int.Parse(txtIteraciones.Text);
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
            
            if (iteraciones > 20) {
                MessageBox.Show("El numero de iteraciones debe ser inferior a 20");
                return;
            }

            for (int x = 0; x < iteraciones; x++) {
                valorAux = new Valores();

                valorAux.xant = x != 0 ? misValores[x - 1].x : xantaux;
                valorAux.yant = x != 0 ? misValores[x - 1].y : yantaux;
                valorAux.u = EvaluarFuncionU(valorAux.xant, valorAux.yant);
                valorAux.v = EvaluarFuncionV(valorAux.xant, valorAux.yant);
                valorAux.dudx = Evaluardudx(valorAux.xant, valorAux.yant);
                valorAux.dudy = Evaluardudy(valorAux.xant, valorAux.yant);
                valorAux.dvdx = Evaluardvdx(valorAux.xant, valorAux.yant);
                valorAux.dvdy = Evaluardvdy(valorAux.xant, valorAux.yant);
                valorAux.x = EvaluarMetodo(valorAux, true);
                valorAux.y = EvaluarMetodo(valorAux, false);

                misValores[x] = valorAux;
            }

            Mostrar();

            MessageBox.Show("Los valores obtenidos son:\n"
                + "\nx: " + valorAux.x
                + "\ny: " + valorAux.y
                + "\n\nRealizado en " + iteraciones + " iteraciones.");
        }

        public void Mostrar() {
            datos.Rows.Clear(); datos2.Rows.Clear();

            for (int x= 0;x < iteraciones;x++) {
                datos.Rows.Add(x+1, misValores[x].u, misValores[x].dudx, misValores[x].dudy, misValores[x].v, misValores[x].dvdx, misValores[x].dvdy);
                datos2.Rows.Add(x+1, misValores[x].xant, misValores[x].yant, misValores[x].x, misValores[x].y);
            }
        }

        public double EvaluarMetodo(Valores v, bool esParax) {
            return esParax ? v.xant - (v.u * v.dvdy - v.v * v.dudy) / (v.dudx * v.dvdy - v.dudy * v.dvdx)
                   : v.yant - (v.v * v.dudx - v.u * v.dvdx) / (v.dudx * v.dvdy - v.dudy * v.dvdx);
        }
        public double EvaluarFuncionU(double x, double y) {
            return -x * x + x + 0.75 - y;
        }

        public double EvaluarFuncionV(double x, double y) {
            return -x * x + y + 5 * x * y;
        }

        public double Evaluardudx(double x, double y) {
            return -2 * x + 1;
        }
        public double Evaluardudy(double x, double y) {
            return -1;
        }
        public double Evaluardvdx(double x, double y) {
            return -2 * x + 5 * y;
        }
        public double Evaluardvdy(double x, double y) {
            return 5 * x + 1;
        }
    }
}
