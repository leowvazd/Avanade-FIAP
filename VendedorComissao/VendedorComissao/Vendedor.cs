using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendedorComissao
{
    class Vendedor
    {
        //atributos
        public string nome { get; set; }
        public double salarioBase { get; set; }

        ////construtor já passando os parametros
        //public Vendedor(String nome, double salarioBase)
        //{
        //    this.nome = nome;
        //    this.salarioBase = salarioBase;
        //}
        
        //construtor passando os parametros posteriormente
        public Vendedor()
        {
            this.nome = "";
            this.salarioBase = 0;
        }

        //metodo
        public double calculoComissao(double valorVendido)
        {
            return valorVendido * 0.1;
        }
    }
}
