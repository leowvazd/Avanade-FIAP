using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthOfYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numero;
            string mensagem;

            if (int.TryParse(txtMes.Text, out numero) == false)
            {
                mensagem = "Por favor digite um número!";
                MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMes.Clear();
                txtMes.Focus();
                return;
            }

            switch(numero)
            {
                case 1:
                    mensagem = "Você escolheu Janeiro!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 2:
                    mensagem = "Você escolheu Fevereiro!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 3:
                    mensagem = "Você escolheu Março!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 4:
                    mensagem = "Você escolheu Abril!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 5:
                    mensagem = "Você escolheu Maio!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 6:
                    mensagem = "Você escolheu Junho!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 7:
                    mensagem = "Você escolheu Julho!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 8:
                    mensagem = "Você escolheu Agosto!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 9:
                    mensagem = "Você escolheu Setembro!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 10:
                    mensagem = "Você escolheu Outubro!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 11:
                    mensagem = "Você escolheu Novembro!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 12:
                    mensagem = "Você escolheu Dezembro!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    mensagem = "Por favor, escolha um número de 1 a 12!";
                    MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMes.Clear();
                    txtMes.Focus();
                    break;
            }
        }
    }
}
