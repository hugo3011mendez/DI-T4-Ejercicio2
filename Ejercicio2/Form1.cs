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


        private void Form1_Load(object sender, EventArgs e)
        {
            lblErrorColor.Text = "";
            lblErrorImagen.Text = "";
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
                lblErrorColor.Text = "";
                BackColor = Color.FromArgb(Convert.ToInt32(txtR.Text), Convert.ToInt32(txtG.Text), Convert.ToInt32(txtB.Text));
            }
            // Informo de los errores via Label
            catch (FormatException) { lblErrorColor.Text = "Debes escribir un número en las 3 cajas de texto para el color"; }
            catch (ArgumentException) { lblErrorColor.Text = "Los números para determinar el color deben de estar entre 0 y 255"; }
        }


        // Función que indica las acciones a realizar por el botón imagen
        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                lblErrorImagen.Text = "";
                Image img = Image.FromFile(txtPath.Text); // Creo y defino una variable con la imagen
                pbImagen.Image = img; // Establezco la imagen en el PictureBox
            }
            catch (IOException) { lblErrorImagen.Text = "Debes indicar una ruta funcional"; }
            catch (ArgumentException) { lblErrorImagen.Text = "Debes escribir una ruta"; }
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
