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

namespace InverterVetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] vetorA = new double[15];
            double[] vetorB = new double[15];

            int j = 14;

            for (int i = 0; i <= 14; i++)
            {
                vetorA[i] = Convert.ToDouble(Interaction.InputBox("Digite o valor deste elemento para o vetor A!"));
                vetorB[j] = vetorA[i];
                j--;
            }

            listBox1.Items.Add(vetorB[0]);
            listBox1.Items.Add(vetorB[1]);
            listBox1.Items.Add(vetorB[2]);
            listBox1.Items.Add(vetorB[3]);
            listBox1.Items.Add(vetorB[4]);
            listBox1.Items.Add(vetorB[5]);
            listBox1.Items.Add(vetorB[6]);
            listBox1.Items.Add(vetorB[7]);
            listBox1.Items.Add(vetorB[8]);
            listBox1.Items.Add(vetorB[9]);
            listBox1.Items.Add(vetorB[10]);
            listBox1.Items.Add(vetorB[11]);
            listBox1.Items.Add(vetorB[12]);
            listBox1.Items.Add(vetorB[13]);
            listBox1.Items.Add(vetorB[14]);
        }
    }
}
