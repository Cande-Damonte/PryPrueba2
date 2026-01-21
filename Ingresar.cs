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
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Requerimiento: Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtContra.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validación de credenciales (Requerimiento 7) [cite: 525]
            if (txtMail.Text == "admin@digitalfarma.com" && txtContra.Text == "1234")
            {
                // Si es correcto, abrimos el formulario principal 
                //FormMain principal = new FormMain();
                //principal.Show();
                this.Hide();
            }
            else
            {
                // Requerimiento 17.1: Mostrar mensaje si son incorrectos 
                MessageBox.Show("Mail o contraseña incorrectos");
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Login registro = new Login();

            // Mostrar el registro
            registro.Show();

            // Ocultar el formulario actual de ingreso
            this.Hide();
        }
    }
}
