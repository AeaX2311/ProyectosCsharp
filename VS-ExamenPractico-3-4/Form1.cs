using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_ExamenPractico_3_4 {
    public partial class Form1 : Form {
        Random rand = new Random();
        Pedido[] miArregloPedidos = new Pedido[100];

        public Form1() {
            InitializeComponent();
            dataGridView1.Columns.Add("Unidades solicitadas", "Unidades solicitadas");
            dataGridView1.Columns.Add("Codigo", "Codigo");
            dataGridView1.Columns.Add("Costo por unidad", "Costo po unidad");
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGenerarAleatorio_Click(object sender, EventArgs e) {
            for(int x = 0; x < 100; x++) {
                Pedido miPedido = new Pedido();

                miPedido.Codigo = GenerarCodigoAleatorio();
                miPedido.UnidadesSolicitadas = rand.Next(0, 15000);
                miPedido.CostoPorUnidad = rand.NextDouble() * (10000 - 100) + 100.0;

                miArregloPedidos[x] = miPedido;
            }

            MessageBox.Show("Se generaron 100 datos de pedidos aleatorios");
            Mostrar();
        }

        private void btnOrdenar_Click(object sender, EventArgs e) {
            if (miArregloPedidos[50] == null) {
                MessageBox.Show("Se necesitan generar los datos primero");
                return;
            }
            
            QuickSort(0, 99);

            MessageBox.Show("Se ordenaron los pedidos segun la cantidad de unidades solicitadas.\n Ordenados ascendentemente mediante metodo de Quick Sort");
            Mostrar();
        }

        private string GenerarCodigoAleatorio() {
            string strCodigo = "PED-";
            char[] posibles = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            int aux = rand.Next(0, 100);

            strCodigo += aux < 10 ? "0" + aux.ToString() : aux.ToString();
            strCodigo += "-";
            for(int x = 0; x < 6; x++) {
                strCodigo += posibles[rand.Next(0, 26)];
            }

            return strCodigo;
        }

        private void Mostrar() {
            dataGridView1.Rows.Clear();

            foreach(Pedido p in miArregloPedidos) {
                dataGridView1.Rows.Add(p.UnidadesSolicitadas, p.Codigo, p.CostoPorUnidad);
            }
        }

        private void QuickSort(int izq, int der) {
            Pedido pedPiv = miArregloPedidos[(izq + der) / 2];
            int i = izq, d = der;

            do {
                while (pedPiv.CompareTo(miArregloPedidos[i]) == 1) i++;
                while (pedPiv.CompareTo(miArregloPedidos[d]) == -1) d--;

                if (i <= d) {
                    Pedido pedAux;
                    pedAux = miArregloPedidos[i];
                    miArregloPedidos[i] = miArregloPedidos[d];
                    miArregloPedidos[d] = pedAux;

                    i++; d--;
                }
            } while (i <= d);

            if (izq < d) QuickSort(izq, d);
            if (i < der) QuickSort(d + 1, der);
        }
    }
}
