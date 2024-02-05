namespace Neumaticos
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.estado = new System.Windows.Forms.StatusStrip();
            this.combobosTablas = new System.Windows.Forms.ComboBox();
            this.btFacturas = new System.Windows.Forms.Button();
            this.btDetalles = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 109);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 316);
            this.dgv.TabIndex = 0;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(0, 428);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(800, 22);
            this.estado.TabIndex = 1;
            this.estado.Text = "statusStrip1";
            // 
            // combobosTablas
            // 
            this.combobosTablas.FormattingEnabled = true;
            this.combobosTablas.Location = new System.Drawing.Point(12, 21);
            this.combobosTablas.Name = "combobosTablas";
            this.combobosTablas.Size = new System.Drawing.Size(194, 21);
            this.combobosTablas.TabIndex = 2;
            this.combobosTablas.SelectedIndexChanged += new System.EventHandler(this.combobosTablas_SelectedIndexChanged);
            // 
            // btFacturas
            // 
            this.btFacturas.Location = new System.Drawing.Point(265, 21);
            this.btFacturas.Name = "btFacturas";
            this.btFacturas.Size = new System.Drawing.Size(75, 23);
            this.btFacturas.TabIndex = 3;
            this.btFacturas.Text = "Facturas";
            this.btFacturas.UseVisualStyleBackColor = true;
            // 
            // btDetalles
            // 
            this.btDetalles.Location = new System.Drawing.Point(384, 21);
            this.btDetalles.Name = "btDetalles";
            this.btDetalles.Size = new System.Drawing.Size(75, 23);
            this.btDetalles.TabIndex = 4;
            this.btDetalles.Text = "Detalles";
            this.btDetalles.UseVisualStyleBackColor = true;
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.Gray;
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btVolver.Location = new System.Drawing.Point(299, 64);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(118, 23);
            this.btVolver.TabIndex = 5;
            this.btVolver.Text = "Volveré";
            this.btVolver.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btDetalles);
            this.Controls.Add(this.btFacturas);
            this.Controls.Add(this.combobosTablas);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.StatusStrip estado;
        private System.Windows.Forms.ComboBox combobosTablas;
        private System.Windows.Forms.Button btFacturas;
        private System.Windows.Forms.Button btDetalles;
        private System.Windows.Forms.Button btVolver;
    }
}

