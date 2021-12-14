using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageKM
{
    public partial class Form1 : Form
    {
        double valorStart, valorEnd, refilledLiters, resultado;             // declaração das variáveis

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            valorStart = Convert.ToDouble(txtStart.Text);                   // convertendo a entrada da TextBox
            valorEnd = Convert.ToDouble(txtFinal.Text);                     // convertendo a entrada da TextBox
            refilledLiters = Convert.ToDouble(txtLiters.Text);              // convertendo a entrada da TextBox

            resultado = ((valorEnd - valorStart) / refilledLiters);         // calculo da autonomia

            lblResultado.Text = resultado.ToString("0.00");                 // convertendo a saida e formatando seu padrão
        }
    }
}
