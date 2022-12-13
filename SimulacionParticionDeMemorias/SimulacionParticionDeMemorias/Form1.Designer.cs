
namespace SimulacionParticionDeMemorias {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMemoriaDinamica = new System.Windows.Forms.Button();
            this.btnO1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMemoriaDinamica);
            this.groupBox1.Controls.Add(this.btnO1);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(640, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona una opcion para continuar";
            // 
            // btnMemoriaDinamica
            // 
            this.btnMemoriaDinamica.Location = new System.Drawing.Point(10, 78);
            this.btnMemoriaDinamica.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemoriaDinamica.Name = "btnMemoriaDinamica";
            this.btnMemoriaDinamica.Size = new System.Drawing.Size(620, 37);
            this.btnMemoriaDinamica.TabIndex = 5;
            this.btnMemoriaDinamica.Text = "Memoria dinámica";
            this.btnMemoriaDinamica.UseVisualStyleBackColor = true;
            this.btnMemoriaDinamica.Click += new System.EventHandler(this.btnMemoriaDinamica_Click);
            // 
            // btnO1
            // 
            this.btnO1.Location = new System.Drawing.Point(10, 31);
            this.btnO1.Margin = new System.Windows.Forms.Padding(5);
            this.btnO1.Name = "btnO1";
            this.btnO1.Size = new System.Drawing.Size(620, 37);
            this.btnO1.TabIndex = 0;
            this.btnO1.Text = "Memoria estática";
            this.btnO1.UseVisualStyleBackColor = true;
            this.btnO1.Click += new System.EventHandler(this.btnO1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(680, 174);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnO1;
        private System.Windows.Forms.Button btnMemoriaDinamica;
    }
}

