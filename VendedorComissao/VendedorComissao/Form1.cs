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
            Comissao comissao = new Comissao(Convert.ToString(txtNome.Text), Convert.ToDouble(txtSalario.Text));

            comissao.calculoComissao(Convert.ToDouble(txtVendido.Text));

            lblRes.Text = comissao.valorVendido.ToString("0.00");
        }
    }
}
