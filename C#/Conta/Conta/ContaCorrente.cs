using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    class ContaCorrente : Conta
    {
        // atributo
        public double limiteEspecial { get; set; }

        // construtor que recebe uma instancia de parametros junto com seus valores 
        public ContaCorrente(double saldo, double limiteEspecial) : base (saldo)
        {
            this.limiteEspecial = limiteEspecial;
        }

        //// construtor que inicilia os atributos toda vez que a classe é chamada
        //public ContaCorrente()
        //{
        //    //this.limiteEspecial = 1000;
        //    //this.saldo = 500;
        //}

        public void mostrarSaldo()
        {
            MessageBox.Show($"O valor do saldo da CC é de R$ {this.saldo.ToString("0.00")}", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void fecharPrograma()
        {
            MessageBox.Show("Obrigado por utilizar!", "Mensagem! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
