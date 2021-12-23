using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public partial class Form1 : Form
    {
        ContaCorrente cc1 = new ContaCorrente(saldo: 500, limiteEspecial: 1000);
        ContaPoupanca cp1 = new ContaPoupanca(saldo: 5000, reajusteMensal: 0.01);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (cmbMenu1.SelectedIndex)
            {
                case 0:
                    switch (cmbMenu2.SelectedIndex)
                    {
                        case 0:
                            validarNumero();
                            if (validar == false)
                            {
                                MessageBox.Show("Por favor digite um código válido!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtValor.Clear();
                                txtValor.Focus();
                                return;
                            }

                            else
                            {
                                cc1.creditar(double.Parse(txtValor.Text));
                                break;
                            }

                        case 1:
                            validarNumero();
                            if (validar == false)
                            {
                                MessageBox.Show("Por favor digite um código válido!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtValor.Clear();
                                txtValor.Focus();
                                return;
                            }

                            else
                            {
                                cc1.debitar(double.Parse(txtValor.Text));
                                break;
                            }

                        case 2:
                            cc1.mostrarSaldo();
                            break;

                        case 3:
                            cc1.fecharPrograma();
                            break;

                        default:
                            MessageBox.Show("Por favor, digite um código válido!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmbMenu1.Focus();
                            return;

                    }
                    break;

                case 1:
                    switch (cmbMenu2.SelectedIndex)
                    {
                        case 0:
                            validarNumero();
                            if (validar == false)
                            {
                                MessageBox.Show("Por favor digite um código válido!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtValor.Clear();
                                txtValor.Focus();
                                return;
                            }

                            else
                            {
                                cp1.creditar(double.Parse(txtValor.Text));
                                break;
                            }

                        case 1:
                            validarNumero();
                            if (validar == false)
                            {
                                MessageBox.Show("Por favor digite um código válido!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtValor.Clear();
                                txtValor.Focus();
                                return;
                            }

                            else
                            {
                                cp1.debitar(double.Parse(txtValor.Text));
                                break;
                            }

                        case 2:
                            cp1.mostrarSaldo();
                            break;

                        case 3:
                            cp1.fecharPrograma();
                            break;

                        default:
                            MessageBox.Show("Por favor, digite um código válido!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmbMenu1.Focus();
                            return;
                    }
                    break;

                case 2:
                    cc1.fecharPrograma();
                    break;

                default:
                    MessageBox.Show("Por favor, digite um código válido!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMenu1.Focus();
                    return;
            }

        }

        public bool validar = false;

        public void validarNumero()
        {
            if (double.TryParse(txtValor.Text, out double result) == false)
            {
                validar = false;
            }

            else
            {
                validar = true;
            }
        }
    }
}
