using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fmrAula1 : Form
    {
        public fmrAula1()
        {
            InitializeComponent();
        }

        private void btnBoasVindas_Click(object sender, EventArgs e)
        {
           

            string NomeUsuario;                                                 // Declaração de variável do tipo String
            
            NomeUsuario = txtNome.Text;


            // Concatenar

            MessageBox.Show($"Bem vindo ao C# {NomeUsuario}", "Olá!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMensagem.Text = ($"Bem vindo ao C# {NomeUsuario}");


        }
    }
}
