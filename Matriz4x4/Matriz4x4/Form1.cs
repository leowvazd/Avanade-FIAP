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

namespace Matriz4x4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[4, 4];

            double soma = 0.00;
            double media = 0.00;
            double[,] matrizM = new double[1, 4];

            // ENTRADA DE DADOS

            for (int linha = 0; linha <= 3; linha++)
            {
                for (int coluna = 0; coluna <= 3; coluna++)
                {
                    matriz[linha, coluna] = Convert.ToInt32(Interaction.InputBox("Digite uma valor para a posição [" + linha.ToString() + "," + coluna.ToString() + "] da matriz."));
                }
            }

            soma = matriz[0, 0] + matriz[0, 1] + matriz[0, 2] + matriz[0, 3];

            media = (matriz[1, 0] + matriz[1, 1] + matriz[1, 2] + matriz[1, 3]) / 4;

            matrizM[0, 0] = matriz[2,0] * matriz[3,0];
            matrizM[0, 1] = matriz[2,1] * matriz[3,1];
            matrizM[0, 2] = matriz[2,2] * matriz[3,2];
            matrizM[0, 3] = matriz[2,3] * matriz[3,3];

            MessageBox.Show("A soma dos elementos da 1ª linha é de: " + soma + ". \nA média dos elementos da 2ª linha é de: " + media + ". \nA multiplicação dos elementos 3ª * 4ª é de: " + matrizM[0, 0] +" "+ matrizM[0, 1] +" "+ matrizM[0, 2] +" "+ matrizM[0, 3] + ". ", "Resultados! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
