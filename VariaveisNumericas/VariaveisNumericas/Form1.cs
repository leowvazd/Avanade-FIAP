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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // DECLARANDO AS VARIAVEIS

            double numero1, numero2, resultado;                 // até 8 decimais

            // LENDO OS VALORES

            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);

            // AQUI CALCULAMOS O RESULTADO DA SOMA

            resultado = numero1 + numero2;

            // MOSTRANDO O RESULTADO NA LABEL3

            lblRes.Text = resultado.ToString("0.00");

        }
    }
}
