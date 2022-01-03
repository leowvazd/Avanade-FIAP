using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Viagem
{
    class Percurso
    {
        // atributos
        public double kmPercorrida { get; set; }
        public double valorPedagio { get; set; }
        public double valorCombustivel {get; set; }

        public Percurso()
        {
            this.kmPercorrida = 0;
            this.valorPedagio = 0;
            this.valorCombustivel = 0;
        }

        public Percurso(double kmPercorrida, double valorPedagio, double valorCombustivel)
        {
            this.kmPercorrida = kmPercorrida;
            this.valorCombustivel = valorCombustivel;
            this.valorPedagio = valorPedagio;
        }

        public void cadastrarPercurso()
        {
            this.kmPercorrida = double.Parse(Interaction.InputBox("Digite a KM Percorrida"));
            this.valorCombustivel = double.Parse(Interaction.InputBox("Digite o valor do Combustível"));
            this.valorPedagio = double.Parse(Interaction.InputBox("Digite o valor do Pedágio"));
            MessageBox.Show("Percurso Cadastrado!");
        }

        public void listarPercurso()
        {
            MessageBox.Show($"Dados do percurso cadastrado:\n\n" +
                $"KM Percorrida: {this.kmPercorrida.ToString()}\n" +
                $"Pedágios: R${this.valorPedagio.ToString("0.00")}\n" +
                $"Combustível: R${this.valorCombustivel.ToString("0.00")}\n");
        }
    }
}
