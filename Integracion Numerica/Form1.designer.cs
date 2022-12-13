namespace Integracion_Numerica {
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorAnalitico = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radS38 = new System.Windows.Forms.RadioButton();
            this.radSn4 = new System.Windows.Forms.RadioButton();
            this.radS = new System.Windows.Forms.RadioButton();
            this.radTn2 = new System.Windows.Forms.RadioButton();
            this.radT = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(156, 19);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(54, 46);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(88, 19);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(62, 20);
            this.txtValorA.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValorAnalitico);
            this.groupBox1.Controls.Add(this.txtValorB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtValorA);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Location = new System.Drawing.Point(183, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura de datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor analitico:";
            // 
            // txtValorAnalitico
            // 
            this.txtValorAnalitico.Location = new System.Drawing.Point(88, 71);
            this.txtValorAnalitico.Name = "txtValorAnalitico";
            this.txtValorAnalitico.Size = new System.Drawing.Size(122, 20);
            this.txtValorAnalitico.TabIndex = 3;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(88, 45);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(62, 20);
            this.txtValorB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor para b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor para a:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "f(x) = 1 - e^-2x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblResultado);
            this.groupBox5.Location = new System.Drawing.Point(12, 194);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 53);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resultados";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(16, 16);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 22);
            this.lblResultado.TabIndex = 16;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radS38);
            this.groupBox6.Controls.Add(this.radSn4);
            this.groupBox6.Controls.Add(this.radS);
            this.groupBox6.Controls.Add(this.radTn2);
            this.groupBox6.Controls.Add(this.radT);
            this.groupBox6.Location = new System.Drawing.Point(12, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(165, 156);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ejecucion";
            // 
            // radS38
            // 
            this.radS38.AutoSize = true;
            this.radS38.Location = new System.Drawing.Point(6, 127);
            this.radS38.Name = "radS38";
            this.radS38.Size = new System.Drawing.Size(131, 17);
            this.radS38.TabIndex = 4;
            this.radS38.TabStop = true;
            this.radS38.Text = "Regla de Simpson 3/8";
            this.radS38.UseVisualStyleBackColor = true;
            this.radS38.CheckedChanged += new System.EventHandler(this.radS38_CheckedChanged);
            // 
            // radSn4
            // 
            this.radSn4.AutoSize = true;
            this.radSn4.Location = new System.Drawing.Point(6, 100);
            this.radSn4.Name = "radSn4";
            this.radSn4.Size = new System.Drawing.Size(155, 17);
            this.radSn4.TabIndex = 3;
            this.radSn4.TabStop = true;
            this.radSn4.Text = "Regla de Simpson 1/3, n=4";
            this.radSn4.UseVisualStyleBackColor = true;
            this.radSn4.CheckedChanged += new System.EventHandler(this.radSn4_CheckedChanged);
            // 
            // radS
            // 
            this.radS.AutoSize = true;
            this.radS.Location = new System.Drawing.Point(6, 72);
            this.radS.Name = "radS";
            this.radS.Size = new System.Drawing.Size(131, 17);
            this.radS.TabIndex = 2;
            this.radS.TabStop = true;
            this.radS.Text = "Regla de Simpson 1/3";
            this.radS.UseVisualStyleBackColor = true;
            this.radS.CheckedChanged += new System.EventHandler(this.radS_CheckedChanged);
            // 
            // radTn2
            // 
            this.radTn2.AutoSize = true;
            this.radTn2.Location = new System.Drawing.Point(6, 46);
            this.radTn2.Name = "radTn2";
            this.radTn2.Size = new System.Drawing.Size(135, 17);
            this.radTn2.TabIndex = 1;
            this.radTn2.TabStop = true;
            this.radTn2.Text = "Regla del trapecio, n=2";
            this.radTn2.UseVisualStyleBackColor = true;
            this.radTn2.CheckedChanged += new System.EventHandler(this.radTn2_CheckedChanged);
            // 
            // radT
            // 
            this.radT.AutoSize = true;
            this.radT.Checked = true;
            this.radT.Location = new System.Drawing.Point(6, 19);
            this.radT.Name = "radT";
            this.radT.Size = new System.Drawing.Size(111, 17);
            this.radT.TabIndex = 0;
            this.radT.TabStop = true;
            this.radT.Text = "Regla del trapecio";
            this.radT.UseVisualStyleBackColor = true;
            this.radT.CheckedChanged += new System.EventHandler(this.radT_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblError);
            this.groupBox7.Location = new System.Drawing.Point(183, 143);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(219, 45);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Error";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(16, 16);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 22);
            this.lblError.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(414, 257);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integracion numérica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radS38;
        private System.Windows.Forms.RadioButton radSn4;
        private System.Windows.Forms.RadioButton radS;
        private System.Windows.Forms.RadioButton radTn2;
        private System.Windows.Forms.RadioButton radT;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorAnalitico;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblError;
    }
}

