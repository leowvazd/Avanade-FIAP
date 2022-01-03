using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_Heranca
{
    class Cd : Produto
    {
        public string artista { get; set; }
        public string gravadora { get; set; }
        public string paisOrigem { get; set; }

        public Cd(string artista, string gravadora, string paisOrigem, string descricao, string genero, int estoqueDisponivel, double precoCusto) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.artista = artista;
            this.gravadora = gravadora;
            this.paisOrigem = paisOrigem;
        }
        public Cd()
        {
            this.artista = "";
            this.gravadora = "";
            this.paisOrigem = "";
            this.descricao = "";
            this.genero = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
        }

        public void listarProduto()
        {
            MessageBox.Show($"Dados do CD cadastrado:\n\n" +
                $"Descrição: {this.descricao}\n" +
                $"Gênero: {this.genero}\n" +
                $"Estoque: {this.estoqueDisponivel}\n" +
                $"Preço de Custo: {this.precoCusto}\n" +
                $"Artista: {this.artista}\n" +
                $"Gravadora: {this.gravadora}\n" +
                $"País de Origem: {this.paisOrigem}", "Mensagem! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
