using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionario
{
    class Vendedor : Funcionario
    {
        public double valorComissao { get; set; }

        public Vendedor(double valorComissao, string nome, string cpf, double salarioBase, double salarioFinal, double valorBonificacao) : base(nome, cpf, salarioBase, salarioFinal, valorBonificacao)
        {
            this.valorComissao = valorComissao;
            this.nome = nome;
            this.cpf = cpf;
            this.salarioBase = salarioBase;
            this.salarioFinal = salarioFinal;
            this.valorBonificacao = valorBonificacao;
        }

        public Vendedor()
        {
            this.valorComissao = 0;
            this.nome = "";
            this.cpf = "";
            this.salarioBase = 0;
            this.salarioFinal = 0;
            this.valorBonificacao = 0;
        }

        public void calcularSalarioFinal()
        {

        }

        public void apresentarSalario()
        {

        }
    }
}
