using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Media10Alunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] vetor = new double[10];

            double media = 0.00;

            for (int i = 0; i <= 9; i++)
            {
                vetor[i] = Convert.ToDouble(Interaction.InputBox("Digite o valor da nota do: "+ (i+1) + " aluno"));
                media = media + vetor[i];
            }

            media = media / 10;

            MessageBox.Show("A média da sala foi de: " + media.ToString("0.00") + ". ", "Média! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
