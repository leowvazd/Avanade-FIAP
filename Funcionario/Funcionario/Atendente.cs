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
        }

        public void calcularSalarioFinal()
        {

        }

        public void apresentarSalario()
        {

        }

    }
}
