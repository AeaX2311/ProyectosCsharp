using System;
using System.Windows.Forms;

namespace Metodo_de_interpolacion_Newton_y_Lagrange {
    public partial class Form1 : Form {
        private double valorGeneralX, valorVerdadero, resultadoN1, resultadoN2, resultadoN3;
        private double[] valoresX = { 1, 4, 6, 5, 0, 0 },
                         valoresFuncionX = { 0, Math.Log(4), Math.Log(6), Math.Log(5), 0, 0 },
                         valoresN1 = new double[6],
                         valoresN2 = new double[6],
                         valoresN3 = new double[6];
        private bool conozcoValorVerdadero;

        public Form1() {
            InitializeComponent(); Inicializar();
            //MessageBox.Show(Math.Log(4) + "");
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            try {
                valorGeneralX = double.Parse(txtX.Text);
                conozcoValorVerdadero = !txtVV.Text.Equals("");
                
                if (conozcoValorVerdadero) valorVerdadero = double.Parse(txtVV.Text);
            }catch(Exception x) {
                MessageBox.Show(x.Message, "Error");
            }

            Limpiar();

            if (radNewton.Checked) InterpolarNewton();
            else InterpolarLagrange();

            Mostrar();
        }

        private void InterpolarNewton() {
            for (int x = 0; x < 3; x++) 
                valoresN1[x] = (valoresFuncionX[x + 1] - valoresFuncionX[x]) / (valoresX[x + 1] - valoresX[x]);

            for (int x = 0; x < 2; x++) 
                valoresN2[x] = (valoresN1[x + 1] - valoresN1[x]) / (valoresX[x + 2] - valoresX[x]);

            valoresN3[0] = (valoresN2[1] - valoresN2[0]) / (valoresX[3] - valoresX[0]);

            resultadoN1 = valoresFuncionX[0] + valoresN1[0] * (valorGeneralX - valoresX[0]);
            resultadoN2 = resultadoN1 + valoresN2[0] * (valorGeneralX - valoresX[0]) * (valorGeneralX - valoresX[1]);
            resultadoN3 = resultadoN2 + valoresN3[0] * (valorGeneralX - valoresX[0]) * (valorGeneralX - valoresX[1])
                          * (valorGeneralX - valoresX[2]);
        }

        private void InterpolarLagrange() {
            valoresN1[0] = (valorGeneralX - valoresX[1]) / (valoresX[0] - valoresX[1]);
            valoresN1[1] = (valorGeneralX - valoresX[0]) / (valoresX[1] - valoresX[0]);


            valoresN2[0] = (valorGeneralX - valoresX[1]) * (valorGeneralX - valoresX[2])
                            / ((valoresX[0] - valoresX[1]) * (valoresX[0] - valoresX[2]));
            valoresN2[1] = (valorGeneralX - valoresX[0]) * (valorGeneralX - valoresX[2])
                            / ((valoresX[1] - valoresX[0]) * (valoresX[1] - valoresX[2]));
            valoresN2[2] = (valorGeneralX - valoresX[0]) * (valorGeneralX - valoresX[1])
                            / ((valoresX[2] - valoresX[0]) * (valoresX[2] - valoresX[1]));


            valoresN3[0] = (valorGeneralX - valoresX[1]) * (valorGeneralX - valoresX[2]) * (valorGeneralX - valoresX[3])
                            / ((valoresX[0] - valoresX[1]) * (valoresX[0] - valoresX[2]) * (valoresX[0] - valoresX[3]));
            valoresN3[1] = (valorGeneralX - valoresX[0]) * (valorGeneralX - valoresX[2]) * (valorGeneralX - valoresX[3])
                            / ((valoresX[1] - valoresX[0]) * (valoresX[1] - valoresX[2]) * (valoresX[1] - valoresX[3]));
            valoresN3[2] = (valorGeneralX - valoresX[0]) * (valorGeneralX - valoresX[1]) * (valorGeneralX - valoresX[3])
                            / ((valoresX[2] - valoresX[0]) * (valoresX[2] - valoresX[1]) * (valoresX[2] - valoresX[3]));
            valoresN3[3] = (valorGeneralX - valoresX[0]) * (valorGeneralX - valoresX[1]) * (valorGeneralX - valoresX[2])
                            / ((valoresX[3] - valoresX[0]) * (valoresX[3] - valoresX[1]) * (valoresX[3] - valoresX[2]));


            resultadoN1 = valoresN1[0] * valoresFuncionX[0] + valoresN1[1] * valoresFuncionX[1];
            resultadoN2 = valoresN2[0] * valoresFuncionX[0] + valoresN2[1] * valoresFuncionX[1]
                          + valoresN2[2] * valoresFuncionX[2];
            resultadoN3 = valoresN3[0] * valoresFuncionX[0] + valoresN3[1] * valoresFuncionX[1]
                          + valoresN3[2] * valoresFuncionX[2] + valoresN3[3] * valoresFuncionX[3];
        }

        private void Mostrar() {
            dgv1.Rows.Clear();

            for(int x = 0; x < 6; x++) dgv1.Rows.Add(valoresN1[x], valoresN2[x], valoresN3[x]);

            dgv3.Rows.Add(resultadoN1, resultadoN2, resultadoN3);
           
            if (conozcoValorVerdadero) 
                dgv3.Rows.Add(ObtenerErrorRelativoPorcentual(resultadoN1) + "%",
                              ObtenerErrorRelativoPorcentual(resultadoN2) + "%",
                              ObtenerErrorRelativoPorcentual(resultadoN3) + "%"); 
        }

        public double ObtenerErrorRelativoPorcentual(double valor) {
            return Math.Abs((valorVerdadero - valor) / valorVerdadero) * 100;
        }

        private void radLagrage_CheckedChanged(object sender, EventArgs e) {
            Limpiar();
        }

        private void radNewton_CheckedChanged(object sender, EventArgs e) {
            Limpiar();
        }

        private void Limpiar() {
            dgv1.Rows.Clear();
            dgv3.Rows.Clear();
            resultadoN1 = 0;
            resultadoN2 = 0;
            resultadoN3 = 0;
            Inicializar();
        }

        private void Inicializar() {
            dgv2.Rows.Clear();

            for (int x = 0; x < 6; x++) { 
                valoresN1[x] = 0;
                valoresN3[x] = 0;
                valoresN2[x] = 0;
                //MessageBox.Show(valoresFuncionX[x] + "");

                dgv2.Rows.Add(x, valoresX[x], valoresFuncionX[x]);
            }

            txtX.Focus();
        }
    }
}
