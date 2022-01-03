using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaldoCaixa
{
    public class Banco
    {
        // atributos
        public double valor;
        public double res;

        // construtor
        public Banco(double valor)
        {
            this.valor = valor;
        }

        // metodos
        public double depositar()
        {
            return res =+ valor;           
        }

        public double sacar ()
        {
            return res -= valor;
        }
    }
}
