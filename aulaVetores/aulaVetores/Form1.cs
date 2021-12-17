using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaVetores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] vetor = new double[5];
            double total;

            vetor[0] = double.Parse(txtV1.Text);
            vetor[1] = double.Parse(txtV2.Text);
            vetor[2] = double.Parse(txtV3.Text);
            vetor[3] = double.Parse(txtV4.Text);
            vetor[4] = double.Parse(txtV5.Text);

            total = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];

            MessageBox.Show("O Total de Vendas foi de: R$ " + total.ToString("0.00") + ".", "Vendas! ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //double V1, V2, V3, V4, V5;

            //double total;

            //V1 = double.Parse(txtV1.Text);
            //V2 = double.Parse(txtV2.Text);
            //V3 = double.Parse(txtV3.Text);
            //V4 = double.Parse(txtV4.Text);
            //V5 = double.Parse(txtV5.Text);

            //total = V1 + V2 + V3 + V4 + V5;

            //MessageBox.Show("O Total de Vendas foi de: R$ " + total.ToString("0.00") + ".", "Vendas! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
