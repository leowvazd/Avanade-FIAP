using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfComposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor, investimento;

            valor = double.Parse(txtInvestimento.Text);

            if (valor < 1000)
            {
                investimento = valor * 0.05;
                MessageBox.Show("O valor do investimento é de: R$ " + investimento.ToString("0.00"), "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                investimento = valor * 0.15;
                MessageBox.Show("O valor do investimento é de: R$ " + investimento.ToString("0.00"), "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
