using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpLogicoOU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double totalCompra, valorFinal;
            string cupom;

            if(double.TryParse(textBox1.Text, out totalCompra) == false)
            {
                MessageBox.Show("Por favor, digite um valor válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                return;
            }

            cupom = textBox2.Text.ToUpper();

            if (totalCompra > 1000 || cupom == "DESCONTO20")
            {
                valorFinal = totalCompra - (totalCompra * 0.20);
            }

            else
            {
                valorFinal = totalCompra;
            }

            MessageBox.Show("Valor final da compra é de: R$ " + valorFinal.ToString("0.00"));
        }
    }
}
