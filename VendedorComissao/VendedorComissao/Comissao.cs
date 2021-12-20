using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedorComissao
{
    class Comissao
    {
        //atributos
        public string nome = "";
        public double salarioBase;
        public double valorVendido;

        //construtor
        public Comissao(String nome, double salarioBase)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }

        //metodo
        public double calculoComissao(double valorVendido)
        {
            return valorVendido += salarioBase * 1.10;
        }
    }
}
