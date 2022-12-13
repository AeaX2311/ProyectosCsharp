namespace VS_ExamenABBPractico {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiguraJPG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiguraSE = new System.Windows.Forms.TextBox();
            this.txtBAT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExaminar1 = new System.Windows.Forms.Button();
            this.btnExaminar2 = new System.Windows.Forms.Button();
            this.btnExaminar3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnExaminar3);
            this.groupBox1.Controls.Add(this.btnExaminar2);
            this.groupBox1.Controls.Add(this.btnExaminar1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFiguraJPG);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFiguraSE);
            this.groupBox1.Controls.Add(this.txtBAT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direccion de..";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Azure;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Location = new System.Drawing.Point(6, 101);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(642, 32);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Donde guardar el archivo Figura.jpg:";
            // 
            // txtFiguraJPG
            // 
            this.txtFiguraJPG.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiguraJPG.Location = new System.Drawing.Point(268, 73);
            this.txtFiguraJPG.Name = "txtFiguraJPG";
            this.txtFiguraJPG.Size = new System.Drawing.Size(265, 22);
            this.txtFiguraJPG.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Donde guardar el archivo Figura sin extension:";
            // 
            // txtFiguraSE
            // 
            this.txtFiguraSE.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiguraSE.Location = new System.Drawing.Point(268, 47);
            this.txtFiguraSE.Name = "txtFiguraSE";
            this.txtFiguraSE.Size = new System.Drawing.Size(265, 22);
            this.txtFiguraSE.TabIndex = 2;
            // 
            // txtBAT
            // 
            this.txtBAT.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAT.Location = new System.Drawing.Point(268, 21);
            this.txtBAT.Name = "txtBAT";
            this.txtBAT.Size = new System.Drawing.Size(265, 22);
            this.txtBAT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Archivo .BAT para ejecutar comandos de DOT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Si se desea poner una \"\\\" colocarla dos veces \"\\\\\"";
            // 
            // btnExaminar1
            // 
            this.btnExaminar1.BackColor = System.Drawing.Color.Azure;
            this.btnExaminar1.Location = new System.Drawing.Point(540, 21);
            this.btnExaminar1.Name = "btnExaminar1";
            this.btnExaminar1.Size = new System.Drawing.Size(108, 22);
            this.btnExaminar1.TabIndex = 6;
            this.btnExaminar1.Text = "Examinar";
            this.btnExaminar1.UseVisualStyleBackColor = false;
            this.btnExaminar1.Click += new System.EventHandler(this.btnExaminar1_Click);
            // 
            // btnExaminar2
            // 
            this.btnExaminar2.BackColor = System.Drawing.Color.Azure;
            this.btnExaminar2.Location = new System.Drawing.Point(539, 47);
            this.btnExaminar2.Name = "btnExaminar2";
            this.btnExaminar2.Size = new System.Drawing.Size(108, 22);
            this.btnExaminar2.TabIndex = 7;
            this.btnExaminar2.Text = "Examinar";
            this.btnExaminar2.UseVisualStyleBackColor = false;
            this.btnExaminar2.Click += new System.EventHandler(this.btnExaminar2_Click);
            // 
            // btnExaminar3
            // 
            this.btnExaminar3.BackColor = System.Drawing.Color.Azure;
            this.btnExaminar3.Location = new System.Drawing.Point(539, 73);
            this.btnExaminar3.Name = "btnExaminar3";
            this.btnExaminar3.Size = new System.Drawing.Size(108, 22);
            this.btnExaminar3.TabIndex = 8;
            this.btnExaminar3.Text = "Examinar";
            this.btnExaminar3.UseVisualStyleBackColor = false;
            this.btnExaminar3.Click += new System.EventHandler(this.btnExaminar3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(678, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutas de acceso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiguraJPG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiguraSE;
        private System.Windows.Forms.TextBox txtBAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExaminar3;
        private System.Windows.Forms.Button btnExaminar2;
        private System.Windows.Forms.Button btnExaminar1;
    }
}