using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankExample
{
    public partial class Form1 : Form
    {
        double saldo = 0.00;                           // esta variavel precisa ser global para não "reiniciar" a variavel dentro da função click-botão
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double valor;
            int codigo;
            string mensagem;

            valor = double.Parse(txtValor.Text);

            if(double.TryParse(txtValor.Text, out valor) == false)
            {
                mensagem = "Por favor, digite um valor válido!";
                MessageBox.Show(mensagem, "Messagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Clear();
                txtValor.Focus();
                return;
            }

            if (valor <= 0)
            {
                mensagem = "Por favor, digite um valor positivo!";
                MessageBox.Show(mensagem, "Messagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Clear();
                txtValor.Focus();
                return;
            }

            if (int.TryParse(txtCodigo.Text, out codigo) == false)
            {
                mensagem = "Por favor, digite um código válido!";
                MessageBox.Show(mensagem, "Messagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }

            if (codigo <= 0 || codigo > 3)
            {
                mensagem = "Por favor, digite um código de 1 a 3!";
                MessageBox.Show(mensagem, "Messagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }

            switch (codigo)
            {
                case 1:
                    saldo = saldo + valor;
                    mensagem = "Depósito realizado com sucesso! :)";
                    MessageBox.Show(mensagem, "Messagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 2:
                    saldo = saldo - valor;
                    mensagem = "Saque realizado com sucesso! :)";
                    MessageBox.Show(mensagem, "Messagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 3:        
                    MessageBox.Show("Seu saldo é de: R$" + saldo.ToString("0.00") + "!", "Messagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    mensagem = "Por favor, digite um código válido!";
                    MessageBox.Show(mensagem, "Messagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                    return;
            }
        }
    }
}
