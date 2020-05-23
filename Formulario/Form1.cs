using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tNombre.Text;
            string apellidos = tApellidos.Text;
            string telefono = tTelefono.Text;
            string texto = "";
            texto = nombre + " " + apellidos + " " + telefono + "\n";

            tListaSocios.Text = tListaSocios.Text.Replace("\n", Environment.NewLine);
            tListaSocios.Text = tListaSocios.Text + texto;
        }
    }
}
