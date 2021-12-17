using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;        // add namespace

namespace vendasInteractionBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] vetor = new double[5];

            double total = 0.00;

            for ( int i = 0; i <= 4; i++)
            {
                vetor[i] = Convert.ToDouble(Interaction.InputBox("Digite o valor das vendas deste vendedor"));
                total = total + vetor[i];
            }

            MessageBox.Show("Total de Vendas: R$ " + total.ToString("0.00") + ". ", "Vendas! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
