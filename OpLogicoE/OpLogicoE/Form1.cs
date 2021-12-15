using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpLogicoE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = txtUsuario.Text.ToLower();
            senha = txtSenha.Text.ToUpper();

            if (usuario == "administrador" && senha == "123")
            {
                MessageBox.Show("Acesso Autorizado", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Acesso Negado", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                MessageBox.Show("Enter key pressed!");
            }
        }
    }
}
