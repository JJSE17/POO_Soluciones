
namespace POO
{
    partial class frmLineas
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
            this.btnDibujar = new System.Windows.Forms.Button();
            this.lblXInicial = new System.Windows.Forms.Label();
            this.txtXInicial = new System.Windows.Forms.TextBox();
            this.lblYInicial = new System.Windows.Forms.Label();
            this.txtYInicial = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadLineas = new System.Windows.Forms.TextBox();
            this.txtXFinal = new System.Windows.Forms.TextBox();
            this.txtYFinal = new System.Windows.Forms.TextBox();
            this.lblXFinal = new System.Windows.Forms.Label();
            this.lblYFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(13, 149);
            this.btnDibujar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(164, 69);
            this.btnDibujar.TabIndex = 0;
            this.btnDibujar.Text = "Dibujar Linea";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // lblXInicial
            // 
            this.lblXInicial.AutoSize = true;
            this.lblXInicial.Location = new System.Drawing.Point(13, 32);
            this.lblXInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXInicial.Name = "lblXInicial";
            this.lblXInicial.Size = new System.Drawing.Size(52, 16);
            this.lblXInicial.TabIndex = 1;
            this.lblXInicial.Text = "X Inicial";
            // 
            // txtXInicial
            // 
            this.txtXInicial.Location = new System.Drawing.Point(73, 26);
            this.txtXInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtXInicial.Name = "txtXInicial";
            this.txtXInicial.Size = new System.Drawing.Size(63, 22);
            this.txtXInicial.TabIndex = 2;
            this.txtXInicial.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // lblYInicial
            // 
            this.lblYInicial.AutoSize = true;
            this.lblYInicial.Location = new System.Drawing.Point(239, 32);
            this.lblYInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYInicial.Name = "lblYInicial";
            this.lblYInicial.Size = new System.Drawing.Size(53, 16);
            this.lblYInicial.TabIndex = 3;
            this.lblYInicial.Text = "Y Inicial";
            // 
            // txtYInicial
            // 
            this.txtYInicial.Location = new System.Drawing.Point(295, 26);
            this.txtYInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtYInicial.Name = "txtYInicial";
            this.txtYInicial.Size = new System.Drawing.Size(61, 22);
            this.txtYInicial.TabIndex = 4;
            this.txtYInicial.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(233, 149);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(123, 16);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad de Lineas";
            // 
            // txtCantidadLineas
            // 
            this.txtCantidadLineas.Location = new System.Drawing.Point(223, 196);
            this.txtCantidadLineas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadLineas.Name = "txtCantidadLineas";
            this.txtCantidadLineas.Size = new System.Drawing.Size(69, 22);
            this.txtCantidadLineas.TabIndex = 6;
            this.txtCantidadLineas.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtXFinal
            // 
            this.txtXFinal.Location = new System.Drawing.Point(73, 74);
            this.txtXFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtXFinal.Name = "txtXFinal";
            this.txtXFinal.Size = new System.Drawing.Size(63, 22);
            this.txtXFinal.TabIndex = 7;
            this.txtXFinal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtYFinal
            // 
            this.txtYFinal.Location = new System.Drawing.Point(295, 74);
            this.txtYFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtYFinal.Name = "txtYFinal";
            this.txtYFinal.Size = new System.Drawing.Size(61, 22);
            this.txtYFinal.TabIndex = 8;
            // 
            // lblXFinal
            // 
            this.lblXFinal.AutoSize = true;
            this.lblXFinal.Location = new System.Drawing.Point(13, 80);
            this.lblXFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXFinal.Name = "lblXFinal";
            this.lblXFinal.Size = new System.Drawing.Size(47, 16);
            this.lblXFinal.TabIndex = 9;
            this.lblXFinal.Text = "X Final";
            // 
            // lblYFinal
            // 
            this.lblYFinal.AutoSize = true;
            this.lblYFinal.Location = new System.Drawing.Point(239, 77);
            this.lblYFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYFinal.Name = "lblYFinal";
            this.lblYFinal.Size = new System.Drawing.Size(48, 16);
            this.lblYFinal.TabIndex = 10;
            this.lblYFinal.Text = "Y Final";
            this.lblYFinal.Click += new System.EventHandler(this.lblYFinal_Click);
            // 
            // frmLineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 554);
            this.Controls.Add(this.lblYFinal);
            this.Controls.Add(this.lblXFinal);
            this.Controls.Add(this.txtYFinal);
            this.Controls.Add(this.txtXFinal);
            this.Controls.Add(this.txtCantidadLineas);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtYInicial);
            this.Controls.Add(this.lblYInicial);
            this.Controls.Add(this.txtXInicial);
            this.Controls.Add(this.lblXInicial);
            this.Controls.Add(this.btnDibujar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLineas";
            this.Text = "Lineas";
            this.Load += new System.EventHandler(this.frmRectangulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label lblXInicial;
        private System.Windows.Forms.TextBox txtXInicial;
        private System.Windows.Forms.Label lblYInicial;
        private System.Windows.Forms.TextBox txtYInicial;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadLineas;
        private System.Windows.Forms.TextBox txtXFinal;
        private System.Windows.Forms.TextBox txtYFinal;
        private System.Windows.Forms.Label lblXFinal;
        private System.Windows.Forms.Label lblYFinal;
    }
}

