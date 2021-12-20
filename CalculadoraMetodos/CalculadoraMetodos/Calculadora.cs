using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMetodos
{
    class Calculadora
    {
        public double n1 {get; set;}
        public double n2 {get; set;}
        public double res {get; set;}

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
