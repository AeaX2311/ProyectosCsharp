namespace VS_Composicion.pizzeria {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDatosPizzeria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.chkJamon = new System.Windows.Forms.CheckBox();
            this.chkChampiniones = new System.Windows.Forms.CheckBox();
            this.chkCarne = new System.Windows.Forms.CheckBox();
            this.chkPinia = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radSQueso = new System.Windows.Forms.RadioButton();
            this.radPepperoni = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTamanio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminarOrden = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDatosPizzeria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la pizzeria";
            // 
            // btnDatosPizzeria
            // 
            this.btnDatosPizzeria.BackColor = System.Drawing.Color.MistyRose;
            this.btnDatosPizzeria.Location = new System.Drawing.Point(303, 19);
            this.btnDatosPizzeria.Name = "btnDatosPizzeria";
            this.btnDatosPizzeria.Size = new System.Drawing.Size(83, 46);
            this.btnDatosPizzeria.TabIndex = 4;
            this.btnDatosPizzeria.Text = "Guardar";
            this.btnDatosPizzeria.UseVisualStyleBackColor = false;
            this.btnDatosPizzeria.Click += new System.EventHandler(this.BtnDatosPizzeria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(61, 45);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(236, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(61, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtmFechaEntrega);
            this.groupBox2.Controls.Add(this.btnOrdenar);
            this.groupBox2.Controls.Add(this.chkJamon);
            this.groupBox2.Controls.Add(this.chkChampiniones);
            this.groupBox2.Controls.Add(this.chkCarne);
            this.groupBox2.Controls.Add(this.chkPinia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.radSQueso);
            this.groupBox2.Controls.Add(this.radPepperoni);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboTamanio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nueva Orden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha entrega";
            // 
            // dtmFechaEntrega
            // 
            this.dtmFechaEntrega.Location = new System.Drawing.Point(88, 19);
            this.dtmFechaEntrega.Name = "dtmFechaEntrega";
            this.dtmFechaEntrega.Size = new System.Drawing.Size(209, 20);
            this.dtmFechaEntrega.TabIndex = 11;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.MistyRose;
            this.btnOrdenar.Location = new System.Drawing.Point(311, 64);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(161, 53);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // chkJamon
            // 
            this.chkJamon.AutoSize = true;
            this.chkJamon.Location = new System.Drawing.Point(6, 77);
            this.chkJamon.Name = "chkJamon";
            this.chkJamon.Size = new System.Drawing.Size(57, 17);
            this.chkJamon.TabIndex = 9;
            this.chkJamon.Text = "Jamon";
            this.chkJamon.UseVisualStyleBackColor = true;
            // 
            // chkChampiniones
            // 
            this.chkChampiniones.AutoSize = true;
            this.chkChampiniones.Location = new System.Drawing.Point(69, 100);
            this.chkChampiniones.Name = "chkChampiniones";
            this.chkChampiniones.Size = new System.Drawing.Size(90, 17);
            this.chkChampiniones.TabIndex = 8;
            this.chkChampiniones.Text = "Champiñones";
            this.chkChampiniones.UseVisualStyleBackColor = true;
            // 
            // chkCarne
            // 
            this.chkCarne.AutoSize = true;
            this.chkCarne.Location = new System.Drawing.Point(6, 100);
            this.chkCarne.Name = "chkCarne";
            this.chkCarne.Size = new System.Drawing.Size(54, 17);
            this.chkCarne.TabIndex = 7;
            this.chkCarne.Text = "Carne";
            this.chkCarne.UseVisualStyleBackColor = true;
            // 
            // chkPinia
            // 
            this.chkPinia.AutoSize = true;
            this.chkPinia.Location = new System.Drawing.Point(69, 77);
            this.chkPinia.Name = "chkPinia";
            this.chkPinia.Size = new System.Drawing.Size(47, 17);
            this.chkPinia.TabIndex = 6;
            this.chkPinia.Text = "Piña";
            this.chkPinia.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingredientes extra:";
            // 
            // radSQueso
            // 
            this.radSQueso.AutoSize = true;
            this.radSQueso.Location = new System.Drawing.Point(380, 41);
            this.radSQueso.Name = "radSQueso";
            this.radSQueso.Size = new System.Drawing.Size(78, 17);
            this.radSQueso.TabIndex = 4;
            this.radSQueso.Text = "Solo queso";
            this.radSQueso.UseVisualStyleBackColor = true;
            // 
            // radPepperoni
            // 
            this.radPepperoni.AutoSize = true;
            this.radPepperoni.Checked = true;
            this.radPepperoni.Location = new System.Drawing.Point(380, 18);
            this.radPepperoni.Name = "radPepperoni";
            this.radPepperoni.Size = new System.Drawing.Size(73, 17);
            this.radPepperoni.TabIndex = 3;
            this.radPepperoni.TabStop = true;
            this.radPepperoni.Text = "Pepperoni";
            this.radPepperoni.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ingrediente\r\nBase:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTamanio
            // 
            this.cboTamanio.FormattingEnabled = true;
            this.cboTamanio.Items.AddRange(new object[] {
            "C - Chica",
            "M - Mediana",
            "G - Grande"});
            this.cboTamanio.Location = new System.Drawing.Point(165, 81);
            this.cboTamanio.Name = "cboTamanio";
            this.cboTamanio.Size = new System.Drawing.Size(140, 21);
            this.cboTamanio.TabIndex = 1;
            this.cboTamanio.Text = "C - Chica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tamaño";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminarOrden);
            this.groupBox3.Controls.Add(this.btnContar);
            this.groupBox3.Controls.Add(this.btnPagar);
            this.groupBox3.Location = new System.Drawing.Point(410, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 206);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otras acciones";
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.Color.MistyRose;
            this.btnContar.Location = new System.Drawing.Point(86, 84);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(108, 56);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "Calcular total de pedidios a realizar";
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.BtnContar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.MistyRose;
            this.btnPagar.Location = new System.Drawing.Point(6, 19);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(188, 56);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar orden seleccionada";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(598, 241);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnEliminarOrden
            // 
            this.btnEliminarOrden.BackColor = System.Drawing.Color.MistyRose;
            this.btnEliminarOrden.Location = new System.Drawing.Point(86, 145);
            this.btnEliminarOrden.Name = "btnEliminarOrden";
            this.btnEliminarOrden.Size = new System.Drawing.Size(108, 55);
            this.btnEliminarOrden.TabIndex = 2;
            this.btnEliminarOrden.Text = "Cancelar orden seleccionada";
            this.btnEliminarOrden.UseVisualStyleBackColor = false;
            this.btnEliminarOrden.Click += new System.EventHandler(this.BtnEliminarOrden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(622, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzeria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDatosPizzeria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.CheckBox chkJamon;
        private System.Windows.Forms.CheckBox chkChampiniones;
        private System.Windows.Forms.CheckBox chkCarne;
        private System.Windows.Forms.CheckBox chkPinia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radSQueso;
        private System.Windows.Forms.RadioButton radPepperoni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTamanio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtmFechaEntrega;
        private System.Windows.Forms.Button btnEliminarOrden;
    }
}

