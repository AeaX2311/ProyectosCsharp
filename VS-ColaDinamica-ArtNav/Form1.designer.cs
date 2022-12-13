namespace VS_ColaDinamica_ArtNav {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radMixta = new System.Windows.Forms.RadioButton();
            this.radPublica = new System.Windows.Forms.RadioButton();
            this.radPrivada = new System.Windows.Forms.RadioButton();
            this.btnAgregarFabrica = new System.Windows.Forms.Button();
            this.txtCantidadProveedores = new System.Windows.Forms.TextBox();
            this.txtCantidadEmpleados = new System.Windows.Forms.TextBox();
            this.dtmFechaInauguracion = new System.Windows.Forms.DateTimePicker();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkTieneCredito = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminarSeleccionado = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Controls.Add(this.txtImagen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radMixta);
            this.groupBox1.Controls.Add(this.radPublica);
            this.groupBox1.Controls.Add(this.radPrivada);
            this.groupBox1.Controls.Add(this.btnAgregarFabrica);
            this.groupBox1.Controls.Add(this.txtCantidadProveedores);
            this.groupBox1.Controls.Add(this.txtCantidadEmpleados);
            this.groupBox1.Controls.Add(this.dtmFechaInauguracion);
            this.groupBox1.Controls.Add(this.cboClasificacion);
            this.groupBox1.Controls.Add(this.txtTamanio);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkTieneCredito);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la fabrica";
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.Azure;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExaminar.Location = new System.Drawing.Point(265, 180);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(76, 18);
            this.btnExaminar.TabIndex = 18;
            this.btnExaminar.Text = "Examinar..";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImagen.Enabled = false;
            this.txtImagen.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.Location = new System.Drawing.Point(59, 181);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(200, 13);
            this.txtImagen.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Imagen:";
            // 
            // radMixta
            // 
            this.radMixta.AutoSize = true;
            this.radMixta.Location = new System.Drawing.Point(178, 210);
            this.radMixta.Name = "radMixta";
            this.radMixta.Size = new System.Drawing.Size(53, 17);
            this.radMixta.TabIndex = 17;
            this.radMixta.Text = "Mixta";
            this.radMixta.UseVisualStyleBackColor = true;
            // 
            // radPublica
            // 
            this.radPublica.AutoSize = true;
            this.radPublica.Location = new System.Drawing.Point(95, 210);
            this.radPublica.Name = "radPublica";
            this.radPublica.Size = new System.Drawing.Size(61, 17);
            this.radPublica.TabIndex = 16;
            this.radPublica.Text = "Pública";
            this.radPublica.UseVisualStyleBackColor = true;
            // 
            // radPrivada
            // 
            this.radPrivada.AutoSize = true;
            this.radPrivada.Checked = true;
            this.radPrivada.Location = new System.Drawing.Point(15, 210);
            this.radPrivada.Name = "radPrivada";
            this.radPrivada.Size = new System.Drawing.Size(62, 17);
            this.radPrivada.TabIndex = 15;
            this.radPrivada.TabStop = true;
            this.radPrivada.Text = "Privada";
            this.radPrivada.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFabrica
            // 
            this.btnAgregarFabrica.BackColor = System.Drawing.Color.Azure;
            this.btnAgregarFabrica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarFabrica.Location = new System.Drawing.Point(241, 207);
            this.btnAgregarFabrica.Name = "btnAgregarFabrica";
            this.btnAgregarFabrica.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarFabrica.TabIndex = 19;
            this.btnAgregarFabrica.Text = "Agregar";
            this.btnAgregarFabrica.UseVisualStyleBackColor = false;
            this.btnAgregarFabrica.Click += new System.EventHandler(this.btnAgregarFabrica_Click);
            // 
            // txtCantidadProveedores
            // 
            this.txtCantidadProveedores.Location = new System.Drawing.Point(141, 150);
            this.txtCantidadProveedores.Name = "txtCantidadProveedores";
            this.txtCantidadProveedores.Size = new System.Drawing.Size(99, 22);
            this.txtCantidadProveedores.TabIndex = 13;
            // 
            // txtCantidadEmpleados
            // 
            this.txtCantidadEmpleados.Location = new System.Drawing.Point(141, 124);
            this.txtCantidadEmpleados.Name = "txtCantidadEmpleados";
            this.txtCantidadEmpleados.Size = new System.Drawing.Size(99, 22);
            this.txtCantidadEmpleados.TabIndex = 12;
            // 
            // dtmFechaInauguracion
            // 
            this.dtmFechaInauguracion.Location = new System.Drawing.Point(141, 98);
            this.dtmFechaInauguracion.Name = "dtmFechaInauguracion";
            this.dtmFechaInauguracion.Size = new System.Drawing.Size(200, 22);
            this.dtmFechaInauguracion.TabIndex = 11;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboClasificacion.DisplayMember = "0,1,2";
            this.cboClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Items.AddRange(new object[] {
            "C-Micro",
            "B-Pequeña",
            "A-Mediana",
            "S-Grande"});
            this.cboClasificacion.Location = new System.Drawing.Point(140, 71);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(201, 21);
            this.cboClasificacion.TabIndex = 10;
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(140, 45);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(100, 22);
            this.txtTamanio.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-4, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cantidad de proveedores:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cantidad de empleados:";
            // 
            // chkTieneCredito
            // 
            this.chkTieneCredito.AutoSize = true;
            this.chkTieneCredito.Location = new System.Drawing.Point(246, 141);
            this.chkTieneCredito.Name = "chkTieneCredito";
            this.chkTieneCredito.Size = new System.Drawing.Size(103, 17);
            this.chkTieneCredito.TabIndex = 14;
            this.chkTieneCredito.Text = "¿Tiene crédito?";
            this.chkTieneCredito.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de inauguración:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clasificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "metros cuadrados.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño del territorio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(370, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.btnEliminarSeleccionado);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.btnEliminarTodo);
            this.groupBox3.Controls.Add(this.btnEliminarUltimo);
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(576, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 236);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // btnEliminarSeleccionado
            // 
            this.btnEliminarSeleccionado.BackColor = System.Drawing.Color.Azure;
            this.btnEliminarSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarSeleccionado.Location = new System.Drawing.Point(6, 141);
            this.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            this.btnEliminarSeleccionado.Size = new System.Drawing.Size(238, 37);
            this.btnEliminarSeleccionado.TabIndex = 4;
            this.btnEliminarSeleccionado.Text = "Eliminar elemento seleccionado";
            this.btnEliminarSeleccionado.UseVisualStyleBackColor = false;
            this.btnEliminarSeleccionado.Click += new System.EventHandler(this.btnEliminarSeleccionado_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Azure;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(6, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(238, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar (elemento en la casilla nombre)";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackColor = System.Drawing.Color.Azure;
            this.btnEliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarTodo.Location = new System.Drawing.Point(6, 184);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(238, 46);
            this.btnEliminarTodo.TabIndex = 2;
            this.btnEliminarTodo.Text = "Vaciar lista";
            this.btnEliminarTodo.UseVisualStyleBackColor = false;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.BackColor = System.Drawing.Color.Azure;
            this.btnEliminarUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarUltimo.Location = new System.Drawing.Point(6, 98);
            this.btnEliminarUltimo.Name = "btnEliminarUltimo";
            this.btnEliminarUltimo.Size = new System.Drawing.Size(238, 36);
            this.btnEliminarUltimo.TabIndex = 1;
            this.btnEliminarUltimo.Text = "Eliminar primer agregado";
            this.btnEliminarUltimo.UseVisualStyleBackColor = false;
            this.btnEliminarUltimo.Click += new System.EventHandler(this.btnEliminarUltimo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Azure;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Location = new System.Drawing.Point(6, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(238, 32);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "<-- Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 233);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(838, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Fabrica de articulos navideños";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkTieneCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadProveedores;
        private System.Windows.Forms.TextBox txtCantidadEmpleados;
        private System.Windows.Forms.DateTimePicker dtmFechaInauguracion;
        private System.Windows.Forms.Button btnAgregarFabrica;
        private System.Windows.Forms.RadioButton radMixta;
        private System.Windows.Forms.RadioButton radPublica;
        private System.Windows.Forms.RadioButton radPrivada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
    }
}

