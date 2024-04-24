namespace SimulatorOS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadingCircle = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCiclos = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.comboBoxApps = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridProcesos = new System.Windows.Forms.DataGridView();
            this.NumProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoProcesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestanteCiclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gridMemoriaVirtual = new System.Windows.Forms.DataGridView();
            this.gridMemoriaRAM = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPromedioRetorno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPromedioEspera = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxProcesoEjecucion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonIniciarSimulacion = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsoRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumoCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsoRam1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumoCPU1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingCircle)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcesos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMemoriaVirtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMemoriaRAM)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadingCircle);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCiclos);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.comboBoxApps);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(389, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar procesos";
            // 
            // loadingCircle
            // 
            this.loadingCircle.Image = global::SimulatorOS.Properties.Resources.loading;
            this.loadingCircle.Location = new System.Drawing.Point(20, 115);
            this.loadingCircle.Name = "loadingCircle";
            this.loadingCircle.Size = new System.Drawing.Size(104, 92);
            this.loadingCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingCircle.TabIndex = 26;
            this.loadingCircle.TabStop = false;
            this.loadingCircle.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(217, 52);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 17);
            this.label19.TabIndex = 24;
            this.label19.Text = "Quantum: 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciclos de Aplicacion:";
            // 
            // txtCiclos
            // 
            this.txtCiclos.Location = new System.Drawing.Point(220, 115);
            this.txtCiclos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiclos.Name = "txtCiclos";
            this.txtCiclos.ReadOnly = true;
            this.txtCiclos.Size = new System.Drawing.Size(67, 20);
            this.txtCiclos.TabIndex = 4;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(149, 164);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(88, 28);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxApps
            // 
            this.comboBoxApps.FormattingEnabled = true;
            this.comboBoxApps.Items.AddRange(new object[] {
            "Google Chrome",
            "Spotify",
            "Microsoft Word",
            "Adobe Photoshop",
            "Visual Studio Code",
            "Outlook",
            "Adobe Illustrator",
            "MySQL",
            "Paint",
            "Teams"});
            this.comboBoxApps.Location = new System.Drawing.Point(14, 88);
            this.comboBoxApps.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxApps.Name = "comboBoxApps";
            this.comboBoxApps.Size = new System.Drawing.Size(158, 21);
            this.comboBoxApps.TabIndex = 1;
            this.comboBoxApps.SelectedIndexChanged += new System.EventHandler(this.comboBoxApps_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplicaciones:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gridProcesos);
            this.groupBox2.Location = new System.Drawing.Point(402, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(644, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista de procesos agregados:";
            // 
            // gridProcesos
            // 
            this.gridProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumProceso,
            this.Ciclos,
            this.TiempoProcesos,
            this.RestanteCiclo,
            this.EstadoProceso,
            this.TiempoFinal,
            this.TiempoRetorno});
            this.gridProcesos.Location = new System.Drawing.Point(9, 56);
            this.gridProcesos.Margin = new System.Windows.Forms.Padding(2);
            this.gridProcesos.Name = "gridProcesos";
            this.gridProcesos.RowHeadersWidth = 51;
            this.gridProcesos.RowTemplate.Height = 24;
            this.gridProcesos.Size = new System.Drawing.Size(624, 153);
            this.gridProcesos.TabIndex = 0;
            // 
            // NumProceso
            // 
            this.NumProceso.HeaderText = "Proceso";
            this.NumProceso.MinimumWidth = 6;
            this.NumProceso.Name = "NumProceso";
            this.NumProceso.ReadOnly = true;
            // 
            // Ciclos
            // 
            this.Ciclos.HeaderText = "Ciclos de tarea";
            this.Ciclos.MinimumWidth = 6;
            this.Ciclos.Name = "Ciclos";
            this.Ciclos.ReadOnly = true;
            // 
            // TiempoProcesos
            // 
            this.TiempoProcesos.HeaderText = "Tiempo";
            this.TiempoProcesos.MinimumWidth = 6;
            this.TiempoProcesos.Name = "TiempoProcesos";
            this.TiempoProcesos.ReadOnly = true;
            // 
            // RestanteCiclo
            // 
            this.RestanteCiclo.HeaderText = "Restante";
            this.RestanteCiclo.MinimumWidth = 6;
            this.RestanteCiclo.Name = "RestanteCiclo";
            this.RestanteCiclo.ReadOnly = true;
            // 
            // EstadoProceso
            // 
            this.EstadoProceso.HeaderText = "Estado";
            this.EstadoProceso.MinimumWidth = 6;
            this.EstadoProceso.Name = "EstadoProceso";
            this.EstadoProceso.ReadOnly = true;
            // 
            // TiempoFinal
            // 
            this.TiempoFinal.HeaderText = "Tiempo de espera";
            this.TiempoFinal.MinimumWidth = 6;
            this.TiempoFinal.Name = "TiempoFinal";
            this.TiempoFinal.ReadOnly = true;
            // 
            // TiempoRetorno
            // 
            this.TiempoRetorno.HeaderText = "Tiempo de retorno";
            this.TiempoRetorno.MinimumWidth = 6;
            this.TiempoRetorno.Name = "TiempoRetorno";
            this.TiempoRetorno.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.gridMemoriaVirtual);
            this.groupBox3.Controls.Add(this.gridMemoriaRAM);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.buttonIniciarSimulacion);
            this.groupBox3.Location = new System.Drawing.Point(9, 244);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(1037, 485);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulacion:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(537, 34);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(169, 17);
            this.label18.TabIndex = 24;
            this.label18.Text = "Procesos Memoria Virtual";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 34);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "Procesos Memoria RAM";
            // 
            // gridMemoriaVirtual
            // 
            this.gridMemoriaVirtual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMemoriaVirtual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMemoriaVirtual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre1,
            this.Proceso1,
            this.UsoRam1,
            this.ConsumoCPU1});
            this.gridMemoriaVirtual.Location = new System.Drawing.Point(527, 54);
            this.gridMemoriaVirtual.Name = "gridMemoriaVirtual";
            this.gridMemoriaVirtual.RowHeadersWidth = 51;
            this.gridMemoriaVirtual.Size = new System.Drawing.Size(486, 156);
            this.gridMemoriaVirtual.TabIndex = 22;
            // 
            // gridMemoriaRAM
            // 
            this.gridMemoriaRAM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMemoriaRAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMemoriaRAM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Proceso,
            this.UsoRam,
            this.ConsumoCPU});
            this.gridMemoriaRAM.Location = new System.Drawing.Point(25, 54);
            this.gridMemoriaRAM.Name = "gridMemoriaRAM";
            this.gridMemoriaRAM.RowHeadersWidth = 51;
            this.gridMemoriaRAM.Size = new System.Drawing.Size(447, 156);
            this.gridMemoriaRAM.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPromedioRetorno);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtPromedioEspera);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(527, 232);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 139);
            this.panel2.TabIndex = 20;
            // 
            // txtPromedioRetorno
            // 
            this.txtPromedioRetorno.Location = new System.Drawing.Point(370, 68);
            this.txtPromedioRetorno.Margin = new System.Windows.Forms.Padding(2);
            this.txtPromedioRetorno.Name = "txtPromedioRetorno";
            this.txtPromedioRetorno.ReadOnly = true;
            this.txtPromedioRetorno.Size = new System.Drawing.Size(67, 20);
            this.txtPromedioRetorno.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(224, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Promedio de retorno:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total:";
            // 
            // txtPromedioEspera
            // 
            this.txtPromedioEspera.Location = new System.Drawing.Point(155, 68);
            this.txtPromedioEspera.Margin = new System.Windows.Forms.Padding(2);
            this.txtPromedioEspera.Name = "txtPromedioEspera";
            this.txtPromedioEspera.ReadOnly = true;
            this.txtPromedioEspera.Size = new System.Drawing.Size(67, 20);
            this.txtPromedioEspera.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Historial:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Promedio de espera:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBoxProcesoEjecucion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(20, 232);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 139);
            this.panel1.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(266, 86);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(63, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(266, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(63, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(63, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(155, 86);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 17);
            this.label16.TabIndex = 12;
            this.label16.Text = "Memoria Virtual:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(155, 53);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Consumo CPU:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(155, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "RAM Disponible:";
            // 
            // textBoxProcesoEjecucion
            // 
            this.textBoxProcesoEjecucion.Location = new System.Drawing.Point(76, 66);
            this.textBoxProcesoEjecucion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProcesoEjecucion.Name = "textBoxProcesoEjecucion";
            this.textBoxProcesoEjecucion.ReadOnly = true;
            this.textBoxProcesoEjecucion.Size = new System.Drawing.Size(67, 20);
            this.textBoxProcesoEjecucion.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "En ejecucion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proceso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Número:";
            // 
            // buttonIniciarSimulacion
            // 
            this.buttonIniciarSimulacion.Location = new System.Drawing.Point(402, 408);
            this.buttonIniciarSimulacion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIniciarSimulacion.Name = "buttonIniciarSimulacion";
            this.buttonIniciarSimulacion.Size = new System.Drawing.Size(190, 45);
            this.buttonIniciarSimulacion.TabIndex = 18;
            this.buttonIniciarSimulacion.Text = "Iniciar";
            this.buttonIniciarSimulacion.UseVisualStyleBackColor = true;
            this.buttonIniciarSimulacion.Click += new System.EventHandler(this.buttonIniciarSimulacion_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.MinimumWidth = 6;
            this.Proceso.Name = "Proceso";
            // 
            // UsoRam
            // 
            this.UsoRam.HeaderText = "Uso RAM";
            this.UsoRam.MinimumWidth = 6;
            this.UsoRam.Name = "UsoRam";
            // 
            // ConsumoCPU
            // 
            this.ConsumoCPU.HeaderText = "Consumo CPU";
            this.ConsumoCPU.MinimumWidth = 6;
            this.ConsumoCPU.Name = "ConsumoCPU";
            // 
            // Nombre1
            // 
            this.Nombre1.HeaderText = "Nombre";
            this.Nombre1.MinimumWidth = 6;
            this.Nombre1.Name = "Nombre1";
            // 
            // Proceso1
            // 
            this.Proceso1.HeaderText = "Proceso";
            this.Proceso1.MinimumWidth = 6;
            this.Proceso1.Name = "Proceso1";
            // 
            // UsoRam1
            // 
            this.UsoRam1.HeaderText = "Uso RAM";
            this.UsoRam1.MinimumWidth = 6;
            this.UsoRam1.Name = "UsoRam1";
            // 
            // ConsumoCPU1
            // 
            this.ConsumoCPU1.HeaderText = "Consumo CPU";
            this.ConsumoCPU1.MinimumWidth = 6;
            this.ConsumoCPU1.Name = "ConsumoCPU1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 740);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simulador de SO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingCircle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcesos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMemoriaVirtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMemoriaRAM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCiclos;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.ComboBox comboBoxApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridProcesos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestanteCiclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoRetorno;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView gridMemoriaVirtual;
        private System.Windows.Forms.DataGridView gridMemoriaRAM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPromedioRetorno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPromedioEspera;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxProcesoEjecucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonIniciarSimulacion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox loadingCircle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsoRam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumoCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsoRam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumoCPU1;
    }
}

