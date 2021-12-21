using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionario
{
    class Funcionario
    {
        //atributos
        public string nome { get; set; }
        public string cpf { get; set; }
        public double salarioBase { get; set; }
        public double salarioFinal { get; set; }
        public double valorBonificacao { get; set; }

        // construtor
        public Funcionario(string nome, string cpf, double salarioBase, double salarioFinal, double valorBonificacao)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.salarioBase = salarioBase;
            this.salarioFinal = salarioFinal;
            this.valorBonificacao = valorBonificacao;
        }

        // construtor
        public Funcionario()
        {
            this.nome = "";
            this.cpf = "";
            this.salarioBase = 0;
            this.salarioFinal = 0;
            this.valorBonificacao = 0;
        }

        public void calcularBonificacao()
        {
            valorBonificacao = salarioBase * 0.05;
        }

        public void cadastrarFuncionario()
        {
            
        }
    }
}
