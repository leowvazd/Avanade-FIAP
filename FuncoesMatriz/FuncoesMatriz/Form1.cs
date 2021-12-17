using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncoesMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Cores = { "vermelho", "verde", "amarelo", "laranja", "azul" };
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tamanho do Array: " + Cores.Length, "Arrays", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstCores.Items.Clear();
            Array.Sort(Cores);

            for (int i = 0; i <= Cores.Length - 1; i++)
            {
                lstCores.Items.Add(Cores[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstCores.Items.Clear();
            Array.Reverse(Cores);
            
            for (int i = 0; i <= Cores.Length -1; i++)
            {
                lstCores.Items.Add(Cores[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstCores.Items.Clear();
            object CorEscolhida = "verde";
            int retorno = Array.BinarySearch(Cores, CorEscolhida);

            if (retorno >= 0)
            {
                lstCores.Items.Add("Índice do Item " + retorno.ToString());
            }

            else
            {
                lstCores.Items.Add("Item não localizado.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lstCores.Items.Clear();
            int ind = Array.IndexOf(Cores, "verde");
            lstCores.Items.Add("O índice do item 'verde é: " + ind);
        }
    }
}
