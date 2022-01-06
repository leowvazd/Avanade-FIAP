using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLIntegration.Negócios;
using SQLIntegration.Banco;

namespace SQLIntegration
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            ClienteBanco cliBanco = new ClienteBanco();
            int gravou;

            cli.nome = txtNome.Text;
            cli.email = txtEmail.Text;
            cli.endereco = txtEndereco.Text;

            try
            {
                gravou = cliBanco.InserirCliente(cli);
                MessageBox.Show("Cliente cadastrado com sucesso", "Incluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar cliente\n" + ex.Message, "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClienteBanco cliBanco = new ClienteBanco();
            DataTable dadosClientes;

            dadosClientes = cliBanco.localizarPorCodigo(Convert.ToInt32(txtCodigo.Text));

            if (dadosClientes.Rows.Count > 0)
            {
                txtNome.Text = dadosClientes.Rows[0][1].ToString();
                txtEmail.Text = dadosClientes.Rows[0][2].ToString();
                txtEndereco.Text = dadosClientes.Rows[0][3].ToString();
            }

            else
            {
                MessageBox.Show("Cliente não localizado");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            ClienteBanco cliBanco = new ClienteBanco();
            int gravou;

            cli.nome = txtNome.Text;
            cli.email = txtEmail.Text;
            cli.endereco = txtEndereco.Text;

            try
            {
                gravou = cliBanco.AlterarCliente(cli);
                MessageBox.Show("Cliente cadastrado com sucesso", "Incluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar cliente\n" + ex.Message, "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            Cliente cli = new Cliente();
            ClienteBanco cliBanco = new ClienteBanco();
            int gravou;

            cli.nome = txtNome.Text;
            cli.email = txtEmail.Text;
            cli.endereco = txtEndereco.Text;

            try
            {
                gravou = cliBanco.ExcluirCliente(cli);
                MessageBox.Show("Cliente cadastrado com sucesso", "Incluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar cliente\n" + ex.Message, "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
