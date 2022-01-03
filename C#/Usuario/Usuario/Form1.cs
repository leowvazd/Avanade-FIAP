using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Declarando um objeto da classe
            Usuario user = new Usuario();

            // Enviando dados aos atributos
            user.nome = txtNome.Text;
            user.email = txtEmail.Text;
            user.login = txtLogin.Text;
            user.senha = txtSenha.Text;

            // Chamar método
            user.provarExistencia();
        }
    }
}
