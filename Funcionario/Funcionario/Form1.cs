using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void fecharApp()
        {
            MessageBox.Show("Obrigado por utilizar o aplicativo! Volte sempre :)", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Gerente gerente = new Gerente();
            Vendedor vendedor = new Vendedor();
            Atendente atendente = new Atendente();

            switch (cmbMenu1.SelectedIndex)
            {

                // gerente
                case 0:
                    {
                        switch (cmbMenu2.SelectedIndex)
                        {
                            // cadastrar func.
                            case 0:
                                validarBonificacao();
                                validarSalario();
                                if (validarS == false || validarB == false)
                                {
                                    MessageBox.Show("Por favor digite um valor de Salario e/ou Bonificação corretamente!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtSalarioBase.Clear();
                                    txtBonus.Clear();
                                    txtSalarioBase.Focus();
                                    return;
                                }

                                else
                                {
                                    gerente = new Gerente(gratificacao: (Convert.ToDouble(txtBonus.Text), nome: txtNome.Text.ToString()),
                                    cpf: (txtCPF.Text.ToString()), salarioBase: Convert.ToDouble(txtSalarioBase.Text), salarioFinal: 0,
                                    valorBonificacao: 0);

                                    MessageBox.Show("Gerente Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }               
                                break;

                            // calc. salario
                            case 1:
                                gerente.gerenteCalcularSalarioFinal();
                                break;

                            // calc. bonificação
                            case 2:
                                gerente.calcularBonificacao();
                                break;

                            // apresen. final
                            case 3:
                                gerente.apresentarSalario();
                                break;

                            // sair
                            case 4:
                                fecharApp();
                                break;

                            // default
                            default:
                                MessageBox.Show("Por favor, digite uma operação válida!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    break;

                // vendedor
                case 1:
                    {
                        switch (cmbMenu2.SelectedIndex)
                        {
                            // cadastrar func.
                            case 0:
                                validarBonificacao();
                                validarSalario();
                                if (validarS == false || validarB == false)
                                {
                                    MessageBox.Show("Por favor digite um valor de Salario e/ou Bonificação corretamente!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtSalarioBase.Clear();
                                    txtBonus.Clear();
                                    txtSalarioBase.Focus();
                                    return;
                                }

                                else
                                {
                                    vendedor = new Vendedor(valorComissao: (Convert.ToDouble(txtBonus.Text), nome: txtNome.Text.ToString()),
                                    cpf: (txtCPF.Text.ToString()), salarioBase: Convert.ToDouble(txtSalarioBase.Text), salarioFinal: 0,
                                    valorBonificacao: 0);

                                    MessageBox.Show("Vendedor Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;

                            // calc. salario
                            case 1:
                                vendedor.calcularSalarioFinal();
                                break;

                            // calc. bonificação
                            case 2:
                                vendedor.calcularBonificacao();
                                break;

                            // apresen. final
                            case 3:
                                vendedor.apresentarSalario();
                                break;

                            // sair
                            case 4:
                                fecharApp();
                                break;

                            // default
                            default:
                                MessageBox.Show("Por favor, digite uma operação válida!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    break;

                // atendente
                case 2:
                    {
                        switch (cmbMenu2.SelectedIndex)
                        {
                            // cadastrar func.
                            case 0:
                                validarBonificacao();
                                validarSalario();
                                if (validarS == false || validarB == false)
                                {
                                    MessageBox.Show("Por favor digite um valor de Salario e/ou Bonificação corretamente!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtSalarioBase.Clear();
                                    txtBonus.Clear();
                                    txtSalarioBase.Focus();
                                    return;
                                }

                                else
                                {
                                    atendente = new Atendente(adicionalNoturno: (Convert.ToDouble(txtBonus.Text), nome: txtNome.Text.ToString()),
                                    cpf: (txtCPF.Text.ToString()), salarioBase: Convert.ToDouble(txtSalarioBase.Text), salarioFinal: 0,
                                    valorBonificacao: 0);

                                    MessageBox.Show("Vendedor Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;

                            // calc. salario
                            case 1:
                                atendente.calcularSalarioFinal();
                                break;

                            // calc. bonificação
                            case 2:
                                atendente.calcularBonificacao();
                                break;

                            // apresen. final
                            case 3:
                                atendente.apresentarSalario();
                                break;

                            // sair
                            case 4:
                                fecharApp();
                                break;

                            // default
                            default:
                                MessageBox.Show("Por favor, digite uma operação válida!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    break;

                // sair
                case 3:
                    fecharApp();
                    break;

                // default
                default:
                    MessageBox.Show("Por favor, digite uma operação válida!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        public bool validarS = false;

        public void validarSalario()
        {
            if (double.TryParse(txtSalarioBase.Text, out double result) == false)
            {
                validarS = false;
            }

            else
            {
                validarS = true;
            }
        }

        public bool validarB = false;

        public void validarBonificacao()
        {
            if (double.TryParse(txtBonus.Text, out double result) == false)
            {
                validarB = false;
            }

            else
            {
                validarB = true;
            }
        }
    }
}