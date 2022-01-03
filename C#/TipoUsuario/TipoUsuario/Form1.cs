using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipoUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            string usuario;

            usuario = txtUsuario.Text.ToUpper();

            if (usuario != "ADMINISTRADOR")
            {
                MessageBox.Show("Você não é administrador! :(", "Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Você é administrador! :)", "Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
