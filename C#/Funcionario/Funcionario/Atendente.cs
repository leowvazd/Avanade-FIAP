using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Funcionario
{
    class Atendente : Funcionario
    {
        public double adicionalNoturno { get; set; }

        public Atendente(double adicionalNoturno, string nome, string cpf, double salarioBase, double salarioFinal, double valorBonificacao) : base(nome, cpf, salarioBase, salarioFinal, valorBonificacao)
        {
            this.adicionalNoturno = adicionalNoturno;
            this.nome = nome;
            this.cpf = cpf;
            this.salarioBase = salarioBase;
            this.salarioFinal = salarioFinal;
            this.valorBonificacao = valorBonificacao;
        }

        public Atendente()
        {
            this.adicionalNoturno = 0;
            this.nome = "";
            this.cpf = "";
            this.salarioBase = 0;
            this.salarioFinal = 0;
            this.valorBonificacao = 0;
        }

        public Atendente((double, string nome) adicionalNoturno, string cpf, double salarioBase, int salarioFinal, int valorBonificacao)
        {
            this.cpf = cpf;
            this.salarioBase = salarioBase;
            this.salarioFinal = salarioFinal;
            this.valorBonificacao = valorBonificacao;
        }

        public void calcularSalarioFinal()
        {
            MessageBox.Show($"O Salário do Atendente é de: R$ {this.salarioBase.ToString("0.00")}", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void apresentarSalario()
        {
            this.salarioFinal = this.salarioBase + this.valorBonificacao + this.adicionalNoturno;
            MessageBox.Show($"O Salário Final do Vendedor é de: R$ {this.salarioFinal.ToString("0.00")}", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
