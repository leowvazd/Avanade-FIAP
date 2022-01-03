using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    class Conta
    {
        // atributo
        public double saldo { get; set; }

        // costrutor
        public Conta(double saldo)
        {
            this.saldo = saldo;
        }

        // construtor
        public Conta()
        {
            this.saldo = 0;
        }

        // metodo
        public void creditar (double valor)
        {          
            saldo += valor;
            MessageBox.Show("Operação creditar realizada com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // metodo
        public void debitar (double valor)
        {
            MessageBox.Show("Operação debitar realizada com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            saldo -= valor;
        }
    }
}
