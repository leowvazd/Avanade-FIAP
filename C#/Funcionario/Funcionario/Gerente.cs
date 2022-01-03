using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionario
{
    class Gerente : Funcionario
    {
        public double gratificacao { get; set; }

        public Gerente(double gratificacao, string nome, string cpf, double salarioBase, double salarioFinal, double valorBonificacao) : base(nome, cpf, salarioBase, salarioFinal, valorBonificacao)
        {
            this.gratificacao = gratificacao;
            this.nome = nome;
            this.cpf = cpf;
            this.salarioBase = salarioBase;
            this.salarioFinal = salarioFinal;
            this.valorBonificacao = valorBonificacao;
        }

        public Gerente()
        {
            this.gratificacao = 0;
            this.nome = "";
            this.cpf = "";
            this.salarioBase = 0;
            this.salarioFinal = 0;
            this.valorBonificacao = 0;

        }

        public Gerente((double, string nome) gratificacao, string cpf, double salarioBase, int salarioFinal, int valorBonificacao)
        {
            this.cpf = cpf;
            this.salarioBase = salarioBase;
            this.salarioFinal = salarioFinal;
            this.valorBonificacao = valorBonificacao;
        }

        public void gerenteCalcularSalarioFinal()
        {
            MessageBox.Show($"O Salário do Gerente é de: R$ {this.salarioBase.ToString("0.00")}", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void apresentarSalario()
        {
            this.salarioFinal = this.salarioBase + this.valorBonificacao + this.gratificacao;
            MessageBox.Show($"O Salário Final do Gerente é de: R$ {this.salarioFinal.ToString("0.00")}", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
