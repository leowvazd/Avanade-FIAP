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

        public Vendedor (double valorComissao, string nome, string cpf, double salarioBase, double salarioFinal, double valorBonificacao) : base(nome, cpf, salarioBase, salarioFinal, valorBonificacao)
        {
            this.valorComissao = valorComissao;
        }

        public void calcularSalarioFinal()
        {

        }

        public void apresentarSalario()
        {

        }
    }
}
