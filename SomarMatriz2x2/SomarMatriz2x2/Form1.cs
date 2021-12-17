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

namespace SomarMatriz2x2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[2, 2];

            double total = 0.00;

            // ENTRADA DE DADOS

            for (int linha = 0; linha <= 1; linha++)
            {
                for (int coluna = 0; coluna <= 1; coluna++)
                {
                    matriz[linha, coluna] = Convert.ToInt32(Interaction.InputBox("Digite uma valor para a posição [" + linha.ToString() + "," + coluna.ToString() + "] da matriz."));
                    total = total + matriz[linha, coluna];
                }
            }

            MessageBox.Show("O total é de: " + total + ". ", "Mensagem! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
