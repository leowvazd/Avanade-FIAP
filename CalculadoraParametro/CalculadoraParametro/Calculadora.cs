using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraParametro
{
    class Calculadora
    {
        public double res, n1, n2;

        // construtor
        public Calculadora(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public void somar()
        {
            res = n1 + n2;
        }
        public void subtrair()
        {
            res = n1 - n2;
        }
        public void multiplicar()
        {
            res = n1 * n2;
        }
        public void dividir()
        {
            res = n1 / n2;
        }
    }
}
