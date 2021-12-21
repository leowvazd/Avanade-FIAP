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

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cmbMenu1.SelectedIndex)
            {
                // gerente
                case 0:
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
                                break;

                            // default
                            default:
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
                                break;

                            // default
                            default:
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
                                break;

                            // default
                            default:
                                break;
                        }
                    }
                    break;

                // sair
                case 3:
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
                                break;

                            // default
                            default:
                                break;
                        }
                    }
                    break;

                // default
                default:
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
                                break;

                            // default
                            default:
                                break;
                        }
                    }
                    break;

            }
        }
    }
}
