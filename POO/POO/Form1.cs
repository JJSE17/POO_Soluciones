using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Fecha: 7/3/2022
/// Autor: Juan Jose Soto Echavarria
/// Descripción: Dibujo de Lineas
/// </summary>

namespace POO
{
    public partial class frmLineas : Form
    {
        Graphics grafico;

        public frmLineas()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                float xi = float.Parse(txtXInicial.Text);
                float yi = float.Parse(txtYInicial.Text);
                float xf = float.Parse(txtXFinal.Text);
                float yf = float.Parse(txtYFinal.Text);

                clsLinea linea = new clsLinea(xi,yi,xf,yf);
                grafico.DrawLine(Pens.Black, xi, yi, xf, yf);
                txtCantidadLineas.Text = Convert.ToString(clsLinea.ContarLineas());

                


            }
            catch (Exception)
            {

                MessageBox.Show("Digite el valor en tipo numerico");
            }
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRectangulo_Load(object sender, EventArgs e)
        {

        }

        private void lblYFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
