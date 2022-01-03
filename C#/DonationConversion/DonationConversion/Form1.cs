using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonationConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double valor, resultado;                                    // declaração das variáveis    

            valor = Convert.ToDouble(txtValor.Text);                    // convertendo a entrada da boxtext

            resultado = valor * 5.64;                                   // 5,64 valor atual do dólar: 14-Dec-2021

            lblResult.Text = resultado.ToString("0.00");                // convertendo a saida e formatando seu padrão

        }
    }
}
