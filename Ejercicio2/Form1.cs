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

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Ejercicio 2", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void pasarPorBoton(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.LightSeaGreen;
        }


        private void salirBoton(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = SystemColors.Control;
        }


        private void btnColor_Click(object sender, EventArgs e)
        {
            try
            {
                BackColor = Color.FromArgb(Convert.ToInt32(txtR.Text), Convert.ToInt32(txtG.Text), Convert.ToInt32(txtB.Text));
            }
            catch (FormatException) { }
            catch (ArgumentException) { }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(txtPath.Text);
                lblImagen.Size = new Size(img.Width, img.Height);
                lblImagen.Image = img;
            }
            catch (IOException) { }
        }


        private void cambiarAcceptButton(object sender, EventArgs e)
        {
            if (sender == txtR || sender == txtG || sender == txtB)
            {
                AcceptButton = btnColor;
            }
            else if (sender == txtPath)
            {
                AcceptButton = btnImagen;
            }
        }
    }
}
