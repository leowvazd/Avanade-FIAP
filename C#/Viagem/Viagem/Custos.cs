using System;
using System.Collections.Generic;
using System.Text;

namespace Viagem
{
    class Custos
    {
        public double totalPercurso { get; set; }

        public Custos()
        {
            totalPercurso = 0;
        }

        public Custos( double totalPercurso)
        {
            this.totalPercurso = totalPercurso;
        }

        public void calcularViagem(Percurso p)
        {
            totalPercurso = p.valorCombustivel + p.valorPedagio;
        }
    }
}
