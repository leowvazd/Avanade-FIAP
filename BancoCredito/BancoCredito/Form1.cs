using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoCredito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double saldo, credito;

            saldo = double.Parse(txtSaldo.Text);

            if (saldo <= 200)
            {
                credito = saldo * 0;
                MessageBox.Show("Seu Saldo Médio é: R$ " + saldo.ToString("0.00") + ". Logo, seu valor de crédito é: R$ " + credito.ToString("0.00"), "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (saldo <= 400)
            {
                credito = saldo * 0.20;
                MessageBox.Show("Seu Saldo Médio é: R$ " + saldo.ToString("0.00") + ". Logo, seu valor de crédito é: R$ " + credito.ToString("0.00"), "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (saldo <= 600)
            {
                credito = saldo * 0.30;
                MessageBox.Show("Seu Saldo Médio é: R$ " + saldo.ToString("0.00") + ". Logo, seu valor de crédito é: R$ " + credito.ToString("0.00"), "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                credito = saldo * 0.40;
                MessageBox.Show("Seu Saldo Médio é: R$ " + saldo.ToString("0.00") + ". Logo, seu valor de crédito é: R$ " + credito.ToString("0.00"), "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSaldo.Clear();
        }
    }
}
