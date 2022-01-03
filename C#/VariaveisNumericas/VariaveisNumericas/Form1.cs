using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariaveisNumericas
{
    public partial class Form1 : Form
    {

        // DECLARANDO AS VARIAVEIS
        // DOUBLE: ATÉ 8 DECIMAIS
        double numero1, numero2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void lerValores()
        {
            // LENDO OS VALORES

            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);
        }

        private void saida()
        {
            // MOSTRANDO O RESULTADO NA LABEL3
            lblRes.Text = resultado.ToString("0.00");
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // LENDO OS VALORES POR FUNÇÃO
            lerValores();

            // AQUI CALCULAMOS O RESULTADO DA SOMA
            resultado = numero1 + numero2;

            // CHAMANDO A FUNÇÃO DE RESULTADO
            saida();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            // LENDO OS VALORES POR FUNÇÃO
            lerValores();

            // AQUI CALCULAMOS O RESULTADO DA SUBTRAÇÃO
            resultado = numero1 - numero2;

            // CHAMANDO A FUNÇÃO DE RESULTADO
            saida();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            // LENDO OS VALORES POR FUNÇÃO
            lerValores();

            // AQUI CALCULAMOS O RESULTADO DA MULTIPLICAÇÃO
            resultado = numero1 * numero2;

            // CHAMANDO A FUNÇÃO DE RESULTADO
            saida();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            // LENDO OS VALORES POR FUNÇÃO
            lerValores();

            // AQUI CALCULAMOS O RESULTADO DA DIVISÃO
            resultado = numero1 / numero2;

            // CHAMANDO A FUNÇÃO DE RESULTADO
            saida();
        }
    }
}
