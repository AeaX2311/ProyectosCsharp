using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_ExamenABBPractico {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            txtBAT.Text = RutasDeAcceso.Bat;
            txtFiguraJPG.Text = RutasDeAcceso.FiguraJpg;
            txtFiguraSE.Text = RutasDeAcceso.FiguraSinExtension;
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if(txtBAT.Text == "" || txtFiguraJPG.Text == "" || txtFiguraSE.Text == "") {
                MessageBox.Show("Favor de rellenar los campos."); return;
            }

            RutasDeAcceso.Bat = txtBAT.Text;
            RutasDeAcceso.FiguraJpg = txtFiguraJPG.Text;
            RutasDeAcceso.FiguraSinExtension = txtFiguraSE.Text;

            Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            Close();
        }

        private void btnExaminar1_Click(object sender, EventArgs e) {
            OpenFileDialog op = new OpenFileDialog(); string strAux = "";
            op.InitialDirectory = "C://";
            op.Filter = "Archivo bat (*.bat) | *.bat";
            if (op.ShowDialog() == DialogResult.OK) {
                strAux = op.FileName;
            }

            strAux = strAux.Replace("\\", "/");
            txtBAT.Text = strAux;
        }

        private void btnExaminar2_Click(object sender, EventArgs e) {
            FolderBrowserDialog op = new FolderBrowserDialog(); string strAux = "";
            op.RootFolder = Environment.SpecialFolder.MyComputer;
            if (op.ShowDialog() == DialogResult.OK) {
                strAux = op.SelectedPath;
            }

            strAux = strAux.Replace("\\", "/"); strAux += "/Figura";
            txtFiguraSE.Text = strAux;
        }

        private void btnExaminar3_Click(object sender, EventArgs e) {
            FolderBrowserDialog op = new FolderBrowserDialog(); string strAux = "";
            op.RootFolder = Environment.SpecialFolder.MyComputer;
            if (op.ShowDialog() == DialogResult.OK) {
                strAux = op.SelectedPath;
            }

            strAux = strAux.Replace("\\", "/"); strAux += "/Figura.jpg";
            txtFiguraJPG.Text = strAux;
        }
    }
}
