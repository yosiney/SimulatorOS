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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxApps = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonIniciarSimulacion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProcesoEjecucion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NumProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoProcesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestanteCiclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.comboBoxApps);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar procesos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(536, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplicaciones:";
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
            this.comboBoxApps.Location = new System.Drawing.Point(33, 83);
            this.comboBoxApps.Name = "comboBoxApps";
            this.comboBoxApps.Size = new System.Drawing.Size(210, 24);
            this.comboBoxApps.TabIndex = 1;
            this.comboBoxApps.SelectedIndexChanged += new System.EventHandler(this.comboBoxApps_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(184, 155);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 35);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(88, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(88, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciclos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumProceso,
            this.Ciclos,
            this.TiempoProcesos,
            this.RestanteCiclo,
            this.EstadoProceso,
            this.TiempoFinal});
            this.dataGridView1.Location = new System.Drawing.Point(25, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(617, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista de procesos agregados:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.buttonIniciarSimulacion);
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1166, 476);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulacion:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonIniciarSimulacion
            // 
            this.buttonIniciarSimulacion.Location = new System.Drawing.Point(452, 393);
            this.buttonIniciarSimulacion.Name = "buttonIniciarSimulacion";
            this.buttonIniciarSimulacion.Size = new System.Drawing.Size(253, 55);
            this.buttonIniciarSimulacion.TabIndex = 7;
            this.buttonIniciarSimulacion.Text = "Iniciar";
            this.buttonIniciarSimulacion.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proceso:";
            // 
            // textBoxProcesoEjecucion
            // 
            this.textBoxProcesoEjecucion.Location = new System.Drawing.Point(102, 81);
            this.textBoxProcesoEjecucion.Name = "textBoxProcesoEjecucion";
            this.textBoxProcesoEjecucion.ReadOnly = true;
            this.textBoxProcesoEjecucion.Size = new System.Drawing.Size(88, 22);
            this.textBoxProcesoEjecucion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Número:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "En ejecucion:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxProcesoEjecucion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(248, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 140);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(524, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 140);
            this.panel2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(88, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Historial:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Procesos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Cantidad:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(302, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(88, 22);
            this.textBox4.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(227, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tiempo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total:";
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
            this.TiempoFinal.HeaderText = "Tiempo final";
            this.TiempoFinal.MinimumWidth = 6;
            this.TiempoFinal.Name = "TiempoFinal";
            this.TiempoFinal.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Simulador de SO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIniciarSimulacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProcesoEjecucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestanteCiclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoFinal;
    }
}

