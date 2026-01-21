using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPrueba2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
             string.IsNullOrWhiteSpace(txtApellido.Text) ||
             string.IsNullOrWhiteSpace(txtMail.Text) ||
             string.IsNullOrWhiteSpace(txtContra.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todo está bien, avanzar al PASO 2 
            AvanzarPaso2();
        }
        private void AvanzarPaso2()
        {
            // 1. Ocultar los controles del Paso 1 (Nombre, Apellido, etc.)
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtMail.Visible = false;
            txtContra.Visible = false;

            // 2. Mostrar los nuevos controles del Paso 2 (ej. un cuadro para código de verificación)
            // txtCodigoVerificacion.Visible = true; 

            // 3. Actualizar el indicador de progreso visual
            // Aquí puedes cambiar el color del círculo del PASO 2 en tu panel lateral
            //panelPaso1.BackColor = Color.LightGray;
            //panelPaso2.BackColor = Color.FromArgb(0, 168, 132); // El verde de tu marca
        }

        private void btnVerContra_Click(object sender, EventArgs e)
        {
            // Cambia el estado de oculto a visible y viceversa [cite: 519, 526]
            txtContra.UseSystemPasswordChar = !txtContra.UseSystemPasswordChar;

            // Cambia el ícono o texto según el estado
            if (txtContra.UseSystemPasswordChar)
            {
                btnVerContra.Text = "👁"; // Ícono cerrado
            }
            else
            {
                btnVerContra.Text = "Ø"; // Ícono abierto
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Esto abrirá el navegador con los términos legales
            System.Diagnostics.Process.Start("https://tu-sitio-farma.com/terminos");
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            int fuerza = txtContra.Text.Length;
            // Esto permite que el color cambie manualmente en algunos sistemas
            progressBarContra.Style = ProgressBarStyle.Continuous;
            if (fuerza < 4)
            {
                progressBarContra.Value = 30;
                progressBarContra.ForeColor = Color.Red;
                lblEstado.Text = "Contraseña insegura";
                lblEstado.ForeColor = Color.Red;
            }
            else if (fuerza < 8)
            {
                progressBarContra.Value = 60;
                progressBarContra.ForeColor = Color.Yellow;
                lblEstado.Text = "Contraseña media";
                lblEstado.ForeColor = Color.Orange;
            }
            else
            {
                progressBarContra.Value = 100;
                progressBarContra.ForeColor = Color.Green;
                lblEstado.Text = "Contraseña segura";
                lblEstado.ForeColor = Color.Green;
            }
        }
    }
}
