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

namespace Matriz3x2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[3, 2];
            int contPares = 0;

            // ENTRADA DE DADOS

            for (int linha = 0; linha <= 2; linha++)
            {
                for ( int coluna = 0; coluna <= 1; coluna++)
                {
                    matriz[linha, coluna] = Convert.ToInt32(Interaction.InputBox("Digite uma valor para a posição [" + linha.ToString() + "," + coluna.ToString() + "] da matriz."));
                }
            }

            // PERCORRENDO A MATRIZ

            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 1; coluna++)
                {
                    if (matriz[linha, coluna] % 2 == 0)
                    {
                        contPares++;
                    }
                }
            }

            MessageBox.Show("A quantidade de números pares é de: " + contPares.ToString() + ". ", "Matrizes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
