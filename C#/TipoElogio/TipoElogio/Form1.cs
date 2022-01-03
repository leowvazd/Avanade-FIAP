using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipoElogio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            int numero;
            string mensagem = "";

            if (int.TryParse(txtElogio.Text, out numero) == false)
            {
                MessageBox.Show("Por favor, digite um código válido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtElogio.Clear();
                txtElogio.Focus();
                return;
            }

            switch (numero)
            {
                case 1:
                    mensagem = "Você escolheu o Elogio Profissional! :)";
                    break;

                case 2:
                    mensagem = "Você escolheu o Elogio Físico! :)";
                    break;

                case 3:
                    mensagem = "Você escolheu o Elogio Pessoal! :)";
                    break;

                default:
                    mensagem = "Por favor, digite um código de 1 a 3!";
                    break;
            }

            MessageBox.Show(mensagem, "Mensagem! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
