
namespace SimulacionParticionDeMemorias {
    partial class MemoriaDinamica {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarPrincipales = new System.Windows.Forms.Button();
            this.cboSistemaOperativo = new System.Windows.Forms.ComboBox();
            this.nudSistemaOperativo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMemoria = new System.Windows.Forms.ComboBox();
            this.nudMemoria = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdTrabajo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarTrabajo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTrabajo = new System.Windows.Forms.ComboBox();
            this.nudTrabajo = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdTrabajoDesasignar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDesasignarTrabajo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMemoriaTotalDisponible = new System.Windows.Forms.Label();
            this.dgvParticiones = new System.Windows.Forms.DataGridView();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bitacora = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvEspera = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSistemaOperativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemoria)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrabajo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitacora)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspera)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarPrincipales);
            this.groupBox1.Controls.Add(this.cboSistemaOperativo);
            this.groupBox1.Controls.Add(this.nudSistemaOperativo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboMemoria);
            this.groupBox1.Controls.Add(this.nudMemoria);
            this.groupBox1.Location = new System.Drawing.Point(352, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(656, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de datos";
            // 
            // btnGuardarPrincipales
            // 
            this.btnGuardarPrincipales.Location = new System.Drawing.Point(562, 32);
            this.btnGuardarPrincipales.Name = "btnGuardarPrincipales";
            this.btnGuardarPrincipales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuardarPrincipales.Size = new System.Drawing.Size(86, 68);
            this.btnGuardarPrincipales.TabIndex = 6;
            this.btnGuardarPrincipales.Text = "Guardar";
            this.btnGuardarPrincipales.UseVisualStyleBackColor = true;
            this.btnGuardarPrincipales.Click += new System.EventHandler(this.btnGuardarPrincipales_Click);
            // 
            // cboSistemaOperativo
            // 
            this.cboSistemaOperativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSistemaOperativo.FormattingEnabled = true;
            this.cboSistemaOperativo.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.cboSistemaOperativo.Location = new System.Drawing.Point(448, 71);
            this.cboSistemaOperativo.Margin = new System.Windows.Forms.Padding(5);
            this.cboSistemaOperativo.Name = "cboSistemaOperativo";
            this.cboSistemaOperativo.Size = new System.Drawing.Size(106, 29);
            this.cboSistemaOperativo.TabIndex = 3;
            // 
            // nudSistemaOperativo
            // 
            this.nudSistemaOperativo.DecimalPlaces = 1;
            this.nudSistemaOperativo.Location = new System.Drawing.Point(263, 71);
            this.nudSistemaOperativo.Margin = new System.Windows.Forms.Padding(5);
            this.nudSistemaOperativo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSistemaOperativo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSistemaOperativo.Name = "nudSistemaOperativo";
            this.nudSistemaOperativo.Size = new System.Drawing.Size(175, 29);
            this.nudSistemaOperativo.TabIndex = 2;
            this.nudSistemaOperativo.ThousandsSeparator = true;
            this.nudSistemaOperativo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamaño del sistema operativo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(80, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamaño de memoria:";
            // 
            // cboMemoria
            // 
            this.cboMemoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemoria.FormattingEnabled = true;
            this.cboMemoria.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.cboMemoria.Location = new System.Drawing.Point(448, 32);
            this.cboMemoria.Margin = new System.Windows.Forms.Padding(5);
            this.cboMemoria.Name = "cboMemoria";
            this.cboMemoria.Size = new System.Drawing.Size(106, 29);
            this.cboMemoria.TabIndex = 1;
            // 
            // nudMemoria
            // 
            this.nudMemoria.DecimalPlaces = 1;
            this.nudMemoria.Location = new System.Drawing.Point(263, 32);
            this.nudMemoria.Margin = new System.Windows.Forms.Padding(5);
            this.nudMemoria.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMemoria.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMemoria.Name = "nudMemoria";
            this.nudMemoria.Size = new System.Drawing.Size(175, 29);
            this.nudMemoria.TabIndex = 0;
            this.nudMemoria.ThousandsSeparator = true;
            this.nudMemoria.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdTrabajo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAgregarTrabajo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboTrabajo);
            this.groupBox2.Controls.Add(this.nudTrabajo);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(13, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 247);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignar trabajo";
            // 
            // txtIdTrabajo
            // 
            this.txtIdTrabajo.Location = new System.Drawing.Point(6, 160);
            this.txtIdTrabajo.Name = "txtIdTrabajo";
            this.txtIdTrabajo.Size = new System.Drawing.Size(182, 29);
            this.txtIdTrabajo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id trabajo:";
            // 
            // btnAgregarTrabajo
            // 
            this.btnAgregarTrabajo.Location = new System.Drawing.Point(6, 204);
            this.btnAgregarTrabajo.Name = "btnAgregarTrabajo";
            this.btnAgregarTrabajo.Size = new System.Drawing.Size(182, 37);
            this.btnAgregarTrabajo.TabIndex = 10;
            this.btnAgregarTrabajo.Text = "Agregar";
            this.btnAgregarTrabajo.UseVisualStyleBackColor = true;
            this.btnAgregarTrabajo.Click += new System.EventHandler(this.btnAgregarTrabajo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tamaño de memoria:";
            // 
            // cboTrabajo
            // 
            this.cboTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrabajo.FormattingEnabled = true;
            this.cboTrabajo.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB"});
            this.cboTrabajo.Location = new System.Drawing.Point(43, 102);
            this.cboTrabajo.Margin = new System.Windows.Forms.Padding(5);
            this.cboTrabajo.Name = "cboTrabajo";
            this.cboTrabajo.Size = new System.Drawing.Size(106, 29);
            this.cboTrabajo.TabIndex = 8;
            // 
            // nudTrabajo
            // 
            this.nudTrabajo.DecimalPlaces = 1;
            this.nudTrabajo.Location = new System.Drawing.Point(12, 63);
            this.nudTrabajo.Margin = new System.Windows.Forms.Padding(5);
            this.nudTrabajo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTrabajo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTrabajo.Name = "nudTrabajo";
            this.nudTrabajo.Size = new System.Drawing.Size(171, 29);
            this.nudTrabajo.TabIndex = 7;
            this.nudTrabajo.ThousandsSeparator = true;
            this.nudTrabajo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIdTrabajoDesasignar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnDesasignarTrabajo);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(13, 484);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 147);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desasignar trabajo";
            // 
            // txtIdTrabajoDesasignar
            // 
            this.txtIdTrabajoDesasignar.Location = new System.Drawing.Point(6, 49);
            this.txtIdTrabajoDesasignar.Name = "txtIdTrabajoDesasignar";
            this.txtIdTrabajoDesasignar.Size = new System.Drawing.Size(182, 29);
            this.txtIdTrabajoDesasignar.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id trabajo:";
            // 
            // btnDesasignarTrabajo
            // 
            this.btnDesasignarTrabajo.Location = new System.Drawing.Point(6, 97);
            this.btnDesasignarTrabajo.Name = "btnDesasignarTrabajo";
            this.btnDesasignarTrabajo.Size = new System.Drawing.Size(182, 37);
            this.btnDesasignarTrabajo.TabIndex = 10;
            this.btnDesasignarTrabajo.Text = "Quitar";
            this.btnDesasignarTrabajo.UseVisualStyleBackColor = true;
            this.btnDesasignarTrabajo.Click += new System.EventHandler(this.btnDesasignarTrabajo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 66);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alan Abiud\r\nCastro Cruz \r\n19100159";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Memoria usable disponible:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMemoriaTotalDisponible
            // 
            this.lblMemoriaTotalDisponible.AutoSize = true;
            this.lblMemoriaTotalDisponible.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoriaTotalDisponible.Location = new System.Drawing.Point(724, 134);
            this.lblMemoriaTotalDisponible.Name = "lblMemoriaTotalDisponible";
            this.lblMemoriaTotalDisponible.Size = new System.Drawing.Size(0, 31);
            this.lblMemoriaTotalDisponible.TabIndex = 14;
            this.lblMemoriaTotalDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvParticiones
            // 
            this.dgvParticiones.AllowUserToAddRows = false;
            this.dgvParticiones.AllowUserToDeleteRows = false;
            this.dgvParticiones.AllowUserToResizeRows = false;
            this.dgvParticiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticiones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvParticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvParticiones.Location = new System.Drawing.Point(6, 28);
            this.dgvParticiones.MultiSelect = false;
            this.dgvParticiones.Name = "dgvParticiones";
            this.dgvParticiones.ReadOnly = true;
            this.dgvParticiones.Size = new System.Drawing.Size(951, 146);
            this.dgvParticiones.TabIndex = 15;
            // 
            // grafica
            // 
            this.grafica.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.grafica.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea4.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.grafica.Legends.Add(legend4);
            this.grafica.Location = new System.Drawing.Point(1182, 12);
            this.grafica.Name = "grafica";
            this.grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grafica.Size = new System.Drawing.Size(466, 723);
            this.grafica.TabIndex = 17;
            this.grafica.Text = "Grafica de memoria";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvParticiones);
            this.groupBox4.Location = new System.Drawing.Point(213, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(963, 182);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trabajos";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bitacora);
            this.groupBox5.Location = new System.Drawing.Point(213, 553);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(963, 182);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bitacora";
            // 
            // bitacora
            // 
            this.bitacora.AllowUserToAddRows = false;
            this.bitacora.AllowUserToDeleteRows = false;
            this.bitacora.AllowUserToResizeRows = false;
            this.bitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bitacora.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.bitacora.Location = new System.Drawing.Point(6, 28);
            this.bitacora.Name = "bitacora";
            this.bitacora.Size = new System.Drawing.Size(951, 146);
            this.bitacora.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Trabajo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1569, 689);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "En MB";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvEspera);
            this.groupBox7.Location = new System.Drawing.Point(213, 359);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(963, 188);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lista de espera";
            // 
            // dgvEspera
            // 
            this.dgvEspera.AllowUserToAddRows = false;
            this.dgvEspera.AllowUserToDeleteRows = false;
            this.dgvEspera.AllowUserToResizeColumns = false;
            this.dgvEspera.AllowUserToResizeRows = false;
            this.dgvEspera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspera.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvEspera.Location = new System.Drawing.Point(6, 28);
            this.dgvEspera.Name = "dgvEspera";
            this.dgvEspera.Size = new System.Drawing.Size(951, 154);
            this.dgvEspera.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Trabajo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 71.06599F;
            this.Column1.HeaderText = "Trabajo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 62.69596F;
            this.Column2.HeaderText = "Tamaño";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 84.75885F;
            this.Column3.HeaderText = "Tamaño disponible";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 181.4792F;
            this.Column4.HeaderText = "Descripcion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // MemoriaDinamica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1660, 747);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.lblMemoriaTotalDisponible);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MemoriaDinamica";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memoria dinamica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSistemaOperativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemoria)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrabajo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bitacora)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMemoria;
        private System.Windows.Forms.NumericUpDown nudMemoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSistemaOperativo;
        private System.Windows.Forms.NumericUpDown nudSistemaOperativo;
        private System.Windows.Forms.Button btnGuardarPrincipales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarTrabajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTrabajo;
        private System.Windows.Forms.NumericUpDown nudTrabajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDesasignarTrabajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMemoriaTotalDisponible;
        private System.Windows.Forms.DataGridView dgvParticiones;
        private System.Windows.Forms.TextBox txtIdTrabajo;
        private System.Windows.Forms.TextBox txtIdTrabajoDesasignar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView bitacora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}