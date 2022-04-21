using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wLibreria
{
    public partial class Libro : Form
    {
        public Libro()
        {
            InitializeComponent();
        }

        private void Libro_Load(object sender, EventArgs e)
        {
            cmb_Sexo.Items.Clear();
            cmb_Nombrelibro.Items.Clear();
            cmb_Sexo.Items.Add("Masculino");
            cmb_Sexo.Items.Add("Femenino");
            cmb_Sexo.Items.Add("NO identificado");
            cmb_Nombrelibro.Items.Add("El principito");
            cmb_Nombrelibro.Items.Add("La chica del tren");
            cmb_Nombrelibro.Items.Add("Hush hush");
            cmb_Nombrelibro.Items.Add("MEIN KEIPTK");
            cmb_Nombrelibro.Items.Add("Los tres cerditos");
        }
    }
}
