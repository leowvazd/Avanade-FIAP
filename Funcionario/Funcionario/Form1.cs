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
                                gerente = new Gerente(gratificacao: (Convert.ToDouble(txtBonus.Text), nome: txtNome.Text.ToString()),
                                cpf: (txtCPF.Text.ToString()), salarioBase: Convert.ToDouble(txtSalarioBase.Text), salarioFinal: 0,
                                valorBonificacao: 0);

                                MessageBox.Show("Gerente Cadastrado Com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                break;

                            // calc. salario
                            case 1:
                                gerente.gerenteCalcularSalarioFinal();
                                break;

                            // calc. bonificação
                            case 2:
                                break;

                            // apresen. final
                            case 3:
                                break;

                            // sair
                            case 4:
                                fecharApp();
                                break;

                            // default
                            default:
                                // tratamento
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
                                break;

                            // calc. salario
                            case 1:
                                break;

                            // calc. bonificação
                            case 2:
                                break;

                            // apresen. final
                            case 3:
                                break;

                            // sair
                            case 4:
                                fecharApp();
                                break;

                            // default
                            default:
                                // tratamento
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
                                break;

                            // calc. salario
                            case 1:
                                break;

                            // calc. bonificação
                            case 2:
                                break;

                            // apresen. final
                            case 3:
                                break;

                            // sair
                            case 4:
                                fecharApp();
                                break;

                            // default
                            default:
                                // tratamento
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
                    // tratamento
                    break;
            }
        }
    }
}