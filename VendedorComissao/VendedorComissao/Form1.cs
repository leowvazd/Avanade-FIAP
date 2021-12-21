using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendedorComissao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Vendedor v = new Vendedor();

            v.nome = txtNome.Text;
            v.salarioBase = double.Parse(txtSalario.Text);

            MessageBox.Show("O valor da comissão é de: R$ " + v.calculoComissao(double.Parse(txtVendido.Text)).ToString() + ".", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
