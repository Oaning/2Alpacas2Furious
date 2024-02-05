namespace Neumaticos.UT3Informes
{
    /// <summary>
    /// Diseño de la ventana Inicio donde se encontrarán los distintos elementos que se van a mostrar.
    /// </summary>
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btClientes = new System.Windows.Forms.Button();
            this.btFacturasClientes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.btFacturasFechas = new System.Windows.Forms.Button();
            this.btGrafico = new System.Windows.Forms.Button();
            this.gpFactCli = new System.Windows.Forms.GroupBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aiuda = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.gpFactCli.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija un informe:";
            // 
            // btClientes
            // 
            this.helpProvider1.SetHelpNavigator(this.btClientes, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.btClientes.Location = new System.Drawing.Point(138, 43);
            this.btClientes.Name = "btClientes";
            this.helpProvider1.SetShowHelp(this.btClientes, true);
            this.btClientes.Size = new System.Drawing.Size(127, 23);
            this.btClientes.TabIndex = 1;
            this.btClientes.Text = "Clientes";
            this.btClientes.UseVisualStyleBackColor = true;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // btFacturasClientes
            // 
            this.btFacturasClientes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btFacturasClientes.Location = new System.Drawing.Point(9, 34);
            this.btFacturasClientes.Name = "btFacturasClientes";
            this.btFacturasClientes.Size = new System.Drawing.Size(127, 23);
            this.btFacturasClientes.TabIndex = 2;
            this.btFacturasClientes.Text = "Facturas de clientes";
            this.btFacturasClientes.UseVisualStyleBackColor = false;
            this.btFacturasClientes.Click += new System.EventHandler(this.btFacturasClientes_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Fabricantes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(222)))), ((int)(((byte)(245)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtHasta);
            this.groupBox1.Controls.Add(this.dtDesde);
            this.groupBox1.Controls.Add(this.btFacturasFechas);
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(129, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de fechas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Elija el rango de fechas: ";
            // 
            // dtHasta
            // 
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(410, 63);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(94, 20);
            this.dtHasta.TabIndex = 11;
            // 
            // dtDesde
            // 
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(260, 62);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(84, 20);
            this.dtDesde.TabIndex = 10;
            // 
            // btFacturasFechas
            // 
            this.btFacturasFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btFacturasFechas.Location = new System.Drawing.Point(9, 32);
            this.btFacturasFechas.Name = "btFacturasFechas";
            this.btFacturasFechas.Size = new System.Drawing.Size(127, 23);
            this.btFacturasFechas.TabIndex = 4;
            this.btFacturasFechas.Text = "Facturas por fechas";
            this.btFacturasFechas.UseVisualStyleBackColor = false;
            this.btFacturasFechas.Click += new System.EventHandler(this.btFacturasFechas_Click);
            // 
            // btGrafico
            // 
            this.btGrafico.Location = new System.Drawing.Point(138, 328);
            this.btGrafico.Name = "btGrafico";
            this.btGrafico.Size = new System.Drawing.Size(127, 23);
            this.btGrafico.TabIndex = 11;
            this.btGrafico.Text = "Ver Gráfico";
            this.btGrafico.UseVisualStyleBackColor = true;
            this.btGrafico.Click += new System.EventHandler(this.btGrafico_Click);
            // 
            // gpFactCli
            // 
            this.gpFactCli.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpFactCli.Controls.Add(this.tbNombre);
            this.gpFactCli.Controls.Add(this.label5);
            this.gpFactCli.Controls.Add(this.btFacturasClientes);
            this.gpFactCli.ForeColor = System.Drawing.Color.DarkBlue;
            this.gpFactCli.Location = new System.Drawing.Point(129, 91);
            this.gpFactCli.Name = "gpFactCli";
            this.gpFactCli.Size = new System.Drawing.Size(567, 85);
            this.gpFactCli.TabIndex = 12;
            this.gpFactCli.TabStop = false;
            this.gpFactCli.Text = "Facturas de clientes";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(203, 46);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(301, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Indique cliente para ver sólo las facturas de éste:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aiuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aiuda
            // 
            this.aiuda.Name = "aiuda";
            this.aiuda.Size = new System.Drawing.Size(70, 20);
            this.aiuda.Text = "Ayúdame";
            this.aiuda.Click += new System.EventHandler(this.ayúdameToolStripMenuItem_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Alumno\\Desktop\\Proyectos Interfaces\\UT3_Neumaticos_OanaIrinaCutitaruCiob" +
    "anu\\Documentation.chm";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 372);
            this.Controls.Add(this.gpFactCli);
            this.Controls.Add(this.btGrafico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Inicio";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Inicio_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpFactCli.ResumeLayout(false);
            this.gpFactCli.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btFacturasClientes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Button btFacturasFechas;
        private System.Windows.Forms.Button btGrafico;
        private System.Windows.Forms.GroupBox gpFactCli;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aiuda;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}