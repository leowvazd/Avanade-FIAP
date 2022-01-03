using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_Heranca
{
    public partial class Form1 : Form
    {
        Livro liv = new Livro();
        Cd cd = new Cd();
        Dvd dvd = new Dvd();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            liv.descricao = txtDescricao.Text;
            liv.autor = txtAutor.Text;
            liv.edicao = txtEdição.Text;
            liv.editora = txtEditora2.Text;
            liv.estoqueDisponivel = int.Parse(txtEstoque.Text);
            liv.genero = txtGenero.Text;
            liv.precoCusto = double.Parse(txtPreco.Text);

            MessageBox.Show("Livro Cadastrado com Sucesso!");
        }

        private void btnCadastrarCD_Click(object sender, EventArgs e)
        {
            cd.descricao = txtDescricao.Text;
            cd.artista = txtArtista.Text;
            cd.gravadora = txtGravadora.Text;
            cd.paisOrigem = txtPais.Text;
            cd.estoqueDisponivel = int.Parse(txtEstoque.Text);
            cd.genero = txtGenero.Text;
            cd.precoCusto = double.Parse(txtPreco.Text);

            MessageBox.Show("CD Cadastrado com Sucesso!");
        }

        private void btnCadastrarDVD_Click(object sender, EventArgs e)
        {
            dvd.descricao = txtDescricao.Text;
            dvd.diretor = txtDiretor.Text;
            dvd.duracao = txtDuracao.Text;
            dvd.censura = txtCensura.Text;
            dvd.estoqueDisponivel = int.Parse(txtEstoque.Text);
            dvd.genero = txtGenero.Text;
            dvd.precoCusto = double.Parse(txtPreco.Text);

            MessageBox.Show("CD Cadastrado com Sucesso!");
        }

        private void btnComprarLivro_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtQuantidade.Text);
            liv.comprar(qtde);

            MessageBox.Show("Compra de Livro confirmada!");
        }

        private void btnComprarCD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtQuantidade.Text);
            cd.comprar(qtde);

            MessageBox.Show("Compra de CD confirmada!");
        }

        private void btnComprarDVD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtQuantidade.Text);
            dvd.comprar(qtde);

            MessageBox.Show("Compra de Livro confirmada!");
        }

        private void btnVenderVender_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtQuantidade.Text);
            liv.vender(qtde);

            //MessageBox.Show("Venda de Livro confirmada!");
        }

        private void btnVenderCD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtQuantidade.Text);
            cd.vender(qtde);

            //MessageBox.Show("Venda de CD confirmada!");
        }

        private void btnVenderDVD_Click(object sender, EventArgs e)
        {
            int qtde = int.Parse(txtQuantidade.Text);
            dvd.vender(qtde);

            //MessageBox.Show("Venda de Livro confirmada!");
        }

        private void btnListarLivro_Click(object sender, EventArgs e)
        {
            liv.listarProduto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cd.listarProduto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dvd.listarProduto();
        }
    }
}
