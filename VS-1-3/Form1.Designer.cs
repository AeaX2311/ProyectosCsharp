namespace VS_1._3 {
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
            if (disposing && (components != null)) {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLVentana = new System.Windows.Forms.TextBox();
            this.txtAPared = new System.Windows.Forms.TextBox();
            this.txtLPared = new System.Windows.Forms.TextBox();
            this.txtAVentana = new System.Windows.Forms.TextBox();
            this.btnCalcularTiempo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Largo de ventana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ancho de ventana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Largo de pared";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ancho de pared";
            // 
            // txtLVentana
            // 
            this.txtLVentana.Location = new System.Drawing.Point(213, 57);
            this.txtLVentana.Name = "txtLVentana";
            this.txtLVentana.Size = new System.Drawing.Size(144, 20);
            this.txtLVentana.TabIndex = 1;
            // 
            // txtAPared
            // 
            this.txtAPared.Location = new System.Drawing.Point(213, 198);
            this.txtAPared.Name = "txtAPared";
            this.txtAPared.Size = new System.Drawing.Size(144, 20);
            this.txtAPared.TabIndex = 4;
            // 
            // txtLPared
            // 
            this.txtLPared.Location = new System.Drawing.Point(213, 137);
            this.txtLPared.Name = "txtLPared";
            this.txtLPared.Size = new System.Drawing.Size(144, 20);
            this.txtLPared.TabIndex = 3;
            // 
            // txtAVentana
            // 
            this.txtAVentana.Location = new System.Drawing.Point(213, 93);
            this.txtAVentana.Name = "txtAVentana";
            this.txtAVentana.Size = new System.Drawing.Size(144, 20);
            this.txtAVentana.TabIndex = 2;
            // 
            // btnCalcularTiempo
            // 
            this.btnCalcularTiempo.Location = new System.Drawing.Point(428, 116);
            this.btnCalcularTiempo.Name = "btnCalcularTiempo";
            this.btnCalcularTiempo.Size = new System.Drawing.Size(75, 60);
            this.btnCalcularTiempo.TabIndex = 8;
            this.btnCalcularTiempo.Text = "Calccular Tiempo";
            this.btnCalcularTiempo.UseVisualStyleBackColor = true;
            this.btnCalcularTiempo.Click += new System.EventHandler(this.BtnCalcularTiempo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 270);
            this.Controls.Add(this.btnCalcularTiempo);
            this.Controls.Add(this.txtAVentana);
            this.Controls.Add(this.txtLPared);
            this.Controls.Add(this.txtAPared);
            this.Controls.Add(this.txtLVentana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLVentana;
        private System.Windows.Forms.TextBox txtAPared;
        private System.Windows.Forms.TextBox txtLPared;
        private System.Windows.Forms.TextBox txtAVentana;
        private System.Windows.Forms.Button btnCalcularTiempo;
    }
}

