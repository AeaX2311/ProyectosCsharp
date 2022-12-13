using System;
using System.Windows.Forms;

namespace MN_Metodo_de_biseccion { //Alan Abiud Castro Cruz - 19100159
    public partial class Form1 : Form {
        private double xl, xu, xr, ea, criterioError, res;

        public Form1() {
            InitializeComponent();

            dataGridView1.Columns.Add("Número de iteracion", "Número de iteracion");
            dataGridView1.Columns.Add("V. Inferior", "V. Inferior");
            dataGridView1.Columns.Add("V. Superior", "V. Superior");
            dataGridView1.Columns.Add("Estimacion de raiz", "Estimacion de raiz");
            dataGridView1.Columns.Add("Error relativo porcentual", "Error relativo porcentual");
             
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtValorInferior.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            Limpiar();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            try {
                xl = double.Parse(txtValorInferior.Text);
                xu = double.Parse(txtValorSuperior.Text);
                criterioError = double.Parse(txtCriterioError.Text);
            }catch(Exception ex) {
                MessageBox.Show("Favor de ingresar datos correctos.\n" + ex.Message); return;
            } finally {
                txtValorInferior.Focus(); Limpiar();
            }
        
            int iteraciones = 1; bool bandera = true;
            while (bandera && iteraciones < 100) {
                xr = (xl + xu) / 2;
                ea = Math.Abs((xu - xl) / (xu + xl)) * 100;
                res = CondicionFF(xl, xr);
             
                if (res < 0) xu = xr;
                else if (res > 0) xl = xr;    
                else bandera = false;
                if (ea < criterioError) bandera = false;
                

                dataGridView1.Rows.Add(iteraciones, xl, xu, xr, ea + "%");
                iteraciones++;
            }

            if (iteraciones == 100) {
                MessageBox.Show("No se encontro la raiz en esos intervalos."); Limpiar(); return;
            }
            MessageBox.Show("La aproximacion de la raiz, en base al criterio de " + criterioError + "% es:\nf(Xl) f(Xu) = " + xr + "\n\n Con un porcentaje de error: " + ((criterioError == 0) ? Math.Round(ea) : ea) + "%\n\n Y " + (iteraciones - 1) + " iteraciones.");
        }

        private double EvaluarFuncion(double x) {
            return 3 * x - Math.Pow(Math.E, x);
        }

        private double CondicionFF(double xl, double xr) {
            return EvaluarFuncion(xl) * EvaluarFuncion(xr);
        }

        private void Limpiar() {
            txtValorInferior.Clear();
            txtValorSuperior.Clear();
            txtCriterioError.Text = "0";
            dataGridView1.Rows.Clear();
        }
    }
}
