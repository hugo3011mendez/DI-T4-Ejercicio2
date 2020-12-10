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

        // Función que indica las acciones a realizar cuando se pulse el botón o la tecla para cerrarlo
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Ejercicio 2", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        // Función que indica la acción que realizará el botón salir cuando se pulse
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        // Función que indica las acciones a realizar cuando el cursor del ratón pase por encima de un botón
        private void pasarPorBoton(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.LightSeaGreen;
        }


        // Función que indica las acciones a realizar cuando el cursor del ratón deje de pasar por encima de un botón
        private void salirBoton(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = SystemColors.Control;
        }


        // Función que indica las acciones a realizar del botón color
        private void btnColor_Click(object sender, EventArgs e)
        {
            try
            {
                BackColor = Color.FromArgb(Convert.ToInt32(txtR.Text), Convert.ToInt32(txtG.Text), Convert.ToInt32(txtB.Text));
            }
            catch (FormatException) { }
            catch (ArgumentException) { }
        }


        // Función que indica las acciones a realizar por el botón imagen
        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(txtPath.Text);
                lblImagen.Size = new Size(img.Width, img.Height);
                lblImagen.Image = img;
            }
            catch (IOException) { }
            catch (ArgumentException) { }
        }


        // Función que indica las acciones a realizar dependiendo de qué TextBox tenga el foco
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
