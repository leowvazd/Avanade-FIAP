using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    class ContaPoupanca : Conta
    {
        // atributo
        public double reajusteMensal { get; set; }

        // construtor que recebe uma instancia de parametros junto com seus valores 
        public ContaPoupanca(double saldo, double reajusteMensal) : base(saldo)
        {
            this.reajusteMensal = reajusteMensal;
        }

        //// construtor que inicilia os atributos toda vez que a classe é chamada
        //public ContaPoupanca()
        //{
        //    this.reajusteMensal = 0.01;
        //    this.saldo = 5000;
        //}

        public void mostrarSaldo()
        {
            MessageBox.Show($"O valor do saldo da CP é de R$ {this.saldo.ToString("0.00")}", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void fecharPrograma()
        {
            MessageBox.Show("Obrigado por utilizar!", "Mensagem! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
