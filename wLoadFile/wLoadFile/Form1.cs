﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/// <summary>
/// Autor:Juan Jose Soto E
/// Fecha:03/05/2022
/// Descripcion:Cargar datos planos
/// UwU
/// </summary>
namespace wLoadFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Stream myStream;
        int counter = 0;
        string line;

        private void btnLineaALinea_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (*.txt) | *.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);

                            while ((line = file.ReadLine()) != null)
                            {
                                txtLineaLinea.Text = txtLineaLinea.Text + line;
                                counter++;
                            }
                            file.Close();
                        }
                    }

                }
                

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message); 
                }
            }
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "ID";
            col1.Width = 200;
            col1.ReadOnly = true;
            dtgCSV.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Nombre";
            col2.Width = 200;   
            col2.ReadOnly = true;
            dtgCSV.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Apellido";
            col3.Width = 200;
            col3.ReadOnly = true;
            dtgCSV.Columns.Add(col3);

            char delimitador = ';';
            string[] valores;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (*.CSV) | *.CSV";

            if ((openFileDialog.ShowDialog()) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);
                        while((line = file.ReadLine()) != null)
                        {
                            if (counter >= 1)
                            {
                                valores = line.Split(delimitador);

                                dtgCSV.Rows.Add(valores.ToArray());
                                counter++;
                            }
                            else
                            {
                                counter++;
                            }
                        }
                        file.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

         
            }
           
        }
    }
}
