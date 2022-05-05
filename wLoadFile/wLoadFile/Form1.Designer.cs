namespace wLoadFile
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
            this.grpCargarArchivo = new System.Windows.Forms.GroupBox();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnLineaALinea = new System.Windows.Forms.Button();
            this.dtgCSV = new System.Windows.Forms.DataGridView();
            this.txtLineaLinea = new System.Windows.Forms.TextBox();
            this.grpCargarArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCargarArchivo
            // 
            this.grpCargarArchivo.Controls.Add(this.btnCSV);
            this.grpCargarArchivo.Controls.Add(this.btnLineaALinea);
            this.grpCargarArchivo.Controls.Add(this.dtgCSV);
            this.grpCargarArchivo.Controls.Add(this.txtLineaLinea);
            this.grpCargarArchivo.Location = new System.Drawing.Point(41, 38);
            this.grpCargarArchivo.Name = "grpCargarArchivo";
            this.grpCargarArchivo.Size = new System.Drawing.Size(735, 378);
            this.grpCargarArchivo.TabIndex = 0;
            this.grpCargarArchivo.TabStop = false;
            this.grpCargarArchivo.Text = "groupBox1";
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(435, 294);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCSV.TabIndex = 3;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // btnLineaALinea
            // 
            this.btnLineaALinea.Location = new System.Drawing.Point(79, 294);
            this.btnLineaALinea.Name = "btnLineaALinea";
            this.btnLineaALinea.Size = new System.Drawing.Size(129, 23);
            this.btnLineaALinea.TabIndex = 2;
            this.btnLineaALinea.Text = "Linea A Linea";
            this.btnLineaALinea.UseVisualStyleBackColor = true;
            this.btnLineaALinea.Click += new System.EventHandler(this.btnLineaALinea_Click);
            // 
            // dtgCSV
            // 
            this.dtgCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCSV.Location = new System.Drawing.Point(375, 62);
            this.dtgCSV.Name = "dtgCSV";
            this.dtgCSV.RowHeadersWidth = 51;
            this.dtgCSV.RowTemplate.Height = 24;
            this.dtgCSV.Size = new System.Drawing.Size(266, 203);
            this.dtgCSV.TabIndex = 1;
            // 
            // txtLineaLinea
            // 
            this.txtLineaLinea.Location = new System.Drawing.Point(45, 62);
            this.txtLineaLinea.Multiline = true;
            this.txtLineaLinea.Name = "txtLineaLinea";
            this.txtLineaLinea.Size = new System.Drawing.Size(254, 203);
            this.txtLineaLinea.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpCargarArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCargarArchivo.ResumeLayout(false);
            this.grpCargarArchivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCargarArchivo;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnLineaALinea;
        private System.Windows.Forms.DataGridView dtgCSV;
        private System.Windows.Forms.TextBox txtLineaLinea;
    }
}

