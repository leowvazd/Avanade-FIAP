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

        public Gerente(double gratificacao, string nome, string cpf, double salarioBase, double salarioFinal, double valorBonificacao) : base (nome, cpf, salarioBase, salarioFinal, valorBonificacao)
        {
            this.gratificacao = gratificacao;
        }

        public void calcularSalarioFinal()
        {
            //gratificacao = 
        }

        public void apresentarSalario()
        {

        }
    }
}
