namespace wLibreria
{
    partial class Libro
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_NomLibro = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_ValorLibro = new System.Windows.Forms.Label();
            this.lbl_IVA = new System.Windows.Forms.Label();
            this.lbl_TOTAL = new System.Windows.Forms.Label();
            this.grb_Libros = new System.Windows.Forms.GroupBox();
            this.rdo_Venta = new System.Windows.Forms.RadioButton();
            this.rdo_Prestamo = new System.Windows.Forms.RadioButton();
            this.brp_ValorLibro = new System.Windows.Forms.GroupBox();
            this.txt_ValorTotal = new System.Windows.Forms.TextBox();
            this.txt_IVA = new System.Windows.Forms.TextBox();
            this.txt_ValorLibro = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.cmb_Nombrelibro = new System.Windows.Forms.ComboBox();
            this.cmb_Sexo = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grb_Libros.SuspendLayout();
            this.brp_ValorLibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerraToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.archivoToolStripMenuItem.MergeIndex = 1;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // cerraToolStripMenuItem
            // 
            this.cerraToolStripMenuItem.Name = "cerraToolStripMenuItem";
            this.cerraToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.cerraToolStripMenuItem.Text = "&Cerra";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(12, 45);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(12, 85);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(61, 16);
            this.lbl_Telefono.TabIndex = 2;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Location = new System.Drawing.Point(12, 126);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(50, 16);
            this.lbl_Cedula.TabIndex = 4;
            this.lbl_Cedula.Text = "Cedula";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(12, 170);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(40, 16);
            this.lbl_Edad.TabIndex = 6;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_NomLibro
            // 
            this.lbl_NomLibro.AutoSize = true;
            this.lbl_NomLibro.Location = new System.Drawing.Point(12, 212);
            this.lbl_NomLibro.Name = "lbl_NomLibro";
            this.lbl_NomLibro.Size = new System.Drawing.Size(85, 16);
            this.lbl_NomLibro.TabIndex = 8;
            this.lbl_NomLibro.Text = "Nombre libro";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(473, 45);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(57, 16);
            this.lbl_Apellido.TabIndex = 10;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(473, 85);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(64, 16);
            this.lbl_Direccion.TabIndex = 12;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(473, 126);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(45, 16);
            this.lbl_email.TabIndex = 14;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Location = new System.Drawing.Point(473, 170);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(38, 16);
            this.lbl_Sexo.TabIndex = 16;
            this.lbl_Sexo.Text = "Sexo";
            // 
            // lbl_ValorLibro
            // 
            this.lbl_ValorLibro.AutoSize = true;
            this.lbl_ValorLibro.Location = new System.Drawing.Point(6, 25);
            this.lbl_ValorLibro.Name = "lbl_ValorLibro";
            this.lbl_ValorLibro.Size = new System.Drawing.Size(68, 16);
            this.lbl_ValorLibro.TabIndex = 18;
            this.lbl_ValorLibro.Text = "Valor libro";
            // 
            // lbl_IVA
            // 
            this.lbl_IVA.AutoSize = true;
            this.lbl_IVA.Location = new System.Drawing.Point(6, 63);
            this.lbl_IVA.Name = "lbl_IVA";
            this.lbl_IVA.Size = new System.Drawing.Size(28, 16);
            this.lbl_IVA.TabIndex = 20;
            this.lbl_IVA.Text = "IVA";
            // 
            // lbl_TOTAL
            // 
            this.lbl_TOTAL.AutoSize = true;
            this.lbl_TOTAL.Location = new System.Drawing.Point(6, 101);
            this.lbl_TOTAL.Name = "lbl_TOTAL";
            this.lbl_TOTAL.Size = new System.Drawing.Size(86, 16);
            this.lbl_TOTAL.TabIndex = 22;
            this.lbl_TOTAL.Text = "Valor TOTAL";
            // 
            // grb_Libros
            // 
            this.grb_Libros.Controls.Add(this.rdo_Venta);
            this.grb_Libros.Controls.Add(this.rdo_Prestamo);
            this.grb_Libros.Location = new System.Drawing.Point(15, 259);
            this.grb_Libros.Name = "grb_Libros";
            this.grb_Libros.Size = new System.Drawing.Size(254, 135);
            this.grb_Libros.TabIndex = 23;
            this.grb_Libros.TabStop = false;
            this.grb_Libros.Text = "Libros";
            // 
            // rdo_Venta
            // 
            this.rdo_Venta.AutoSize = true;
            this.rdo_Venta.Location = new System.Drawing.Point(6, 76);
            this.rdo_Venta.Name = "rdo_Venta";
            this.rdo_Venta.Size = new System.Drawing.Size(63, 20);
            this.rdo_Venta.TabIndex = 26;
            this.rdo_Venta.TabStop = true;
            this.rdo_Venta.Text = "Venta";
            this.rdo_Venta.UseVisualStyleBackColor = true;
            // 
            // rdo_Prestamo
            // 
            this.rdo_Prestamo.AutoSize = true;
            this.rdo_Prestamo.Location = new System.Drawing.Point(6, 36);
            this.rdo_Prestamo.Name = "rdo_Prestamo";
            this.rdo_Prestamo.Size = new System.Drawing.Size(86, 20);
            this.rdo_Prestamo.TabIndex = 24;
            this.rdo_Prestamo.TabStop = true;
            this.rdo_Prestamo.Text = "Prestamo";
            this.rdo_Prestamo.UseVisualStyleBackColor = true;
            // 
            // brp_ValorLibro
            // 
            this.brp_ValorLibro.Controls.Add(this.lbl_ValorLibro);
            this.brp_ValorLibro.Controls.Add(this.txt_ValorTotal);
            this.brp_ValorLibro.Controls.Add(this.lbl_IVA);
            this.brp_ValorLibro.Controls.Add(this.txt_IVA);
            this.brp_ValorLibro.Controls.Add(this.lbl_TOTAL);
            this.brp_ValorLibro.Controls.Add(this.txt_ValorLibro);
            this.brp_ValorLibro.Location = new System.Drawing.Point(275, 259);
            this.brp_ValorLibro.Name = "brp_ValorLibro";
            this.brp_ValorLibro.Size = new System.Drawing.Size(243, 135);
            this.brp_ValorLibro.TabIndex = 1;
            this.brp_ValorLibro.TabStop = false;
            this.brp_ValorLibro.Text = "Valor del libro";
            // 
            // txt_ValorTotal
            // 
            this.txt_ValorTotal.Location = new System.Drawing.Point(114, 95);
            this.txt_ValorTotal.Name = "txt_ValorTotal";
            this.txt_ValorTotal.Size = new System.Drawing.Size(100, 22);
            this.txt_ValorTotal.TabIndex = 46;
            // 
            // txt_IVA
            // 
            this.txt_IVA.Location = new System.Drawing.Point(114, 57);
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.Size = new System.Drawing.Size(100, 22);
            this.txt_IVA.TabIndex = 44;
            // 
            // txt_ValorLibro
            // 
            this.txt_ValorLibro.Location = new System.Drawing.Point(114, 22);
            this.txt_ValorLibro.Name = "txt_ValorLibro";
            this.txt_ValorLibro.Size = new System.Drawing.Size(100, 22);
            this.txt_ValorLibro.TabIndex = 42;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(103, 45);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 22);
            this.Txt_Nombre.TabIndex = 24;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(103, 85);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 22);
            this.txt_Telefono.TabIndex = 26;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(103, 126);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(100, 22);
            this.txt_Cedula.TabIndex = 28;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(103, 167);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 22);
            this.txt_Edad.TabIndex = 30;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(543, 45);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 22);
            this.txt_Apellido.TabIndex = 34;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(543, 85);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(100, 22);
            this.txt_Direccion.TabIndex = 36;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(543, 126);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 22);
            this.txt_Email.TabIndex = 38;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(954, 62);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(148, 63);
            this.btn_Guardar.TabIndex = 41;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(954, 149);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(148, 64);
            this.btn_Limpiar.TabIndex = 42;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(954, 243);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(148, 57);
            this.btn_Salir.TabIndex = 44;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // cmb_Nombrelibro
            // 
            this.cmb_Nombrelibro.FormattingEnabled = true;
            this.cmb_Nombrelibro.Location = new System.Drawing.Point(103, 204);
            this.cmb_Nombrelibro.Name = "cmb_Nombrelibro";
            this.cmb_Nombrelibro.Size = new System.Drawing.Size(100, 24);
            this.cmb_Nombrelibro.TabIndex = 45;
            // 
            // cmb_Sexo
            // 
            this.cmb_Sexo.FormattingEnabled = true;
            this.cmb_Sexo.Location = new System.Drawing.Point(543, 162);
            this.cmb_Sexo.Name = "cmb_Sexo";
            this.cmb_Sexo.Size = new System.Drawing.Size(100, 24);
            this.cmb_Sexo.TabIndex = 46;
            // 
            // Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 613);
            this.Controls.Add(this.cmb_Sexo);
            this.Controls.Add(this.cmb_Nombrelibro);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Cedula);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.brp_ValorLibro);
            this.Controls.Add(this.grb_Libros);
            this.Controls.Add(this.lbl_Sexo);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_NomLibro);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_Cedula);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Libro";
            this.Text = "Libro";
            this.Load += new System.EventHandler(this.Libro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grb_Libros.ResumeLayout(false);
            this.grb_Libros.PerformLayout();
            this.brp_ValorLibro.ResumeLayout(false);
            this.brp_ValorLibro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label lbl_NomLibro;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_ValorLibro;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.Label lbl_TOTAL;
        private System.Windows.Forms.GroupBox grb_Libros;
        private System.Windows.Forms.RadioButton rdo_Venta;
        private System.Windows.Forms.RadioButton rdo_Prestamo;
        private System.Windows.Forms.GroupBox brp_ValorLibro;
        private System.Windows.Forms.TextBox txt_ValorTotal;
        private System.Windows.Forms.TextBox txt_IVA;
        private System.Windows.Forms.TextBox txt_ValorLibro;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ComboBox cmb_Nombrelibro;
        private System.Windows.Forms.ComboBox cmb_Sexo;
    }
}