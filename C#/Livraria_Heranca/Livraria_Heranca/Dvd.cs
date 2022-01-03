using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_Heranca
{
    class Dvd : Produto
    {
        public string diretor { get; set; }
        public string duracao { get; set; }
        public string censura { get; set; }

        public Dvd(string diretor, string duracao, string censura, string descricao, string genero, int estoqueDisponivel, double precoCusto) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.diretor = diretor;
            this.duracao = duracao;
            this.censura = censura;
        }

        public Dvd()
        {
            this.diretor = "";
            this.duracao = "";
            this.censura = "";
            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
        }

        public void listarProduto()
        {
            MessageBox.Show($"Dados do DVD cadastrado:\n\n" +
                $"Descrição: {this.descricao}\n" +
                $"Gênero: {this.genero}\n" +
                $"Estoque: {this.estoqueDisponivel}\n" +
                $"Preço de Custo: {this.precoCusto}\n" +
                $"Diretor: {this.diretor}\n" +
                $"Duração: {this.duracao}\n" +
                $"Censura: {this.censura}", "Mensagem! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
