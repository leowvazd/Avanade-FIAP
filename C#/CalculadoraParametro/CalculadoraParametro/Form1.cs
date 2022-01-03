using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraParametro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora(Convert.ToDouble(txtN1.Text), Convert.ToDouble(txtN2.Text));

            calc.somar();
            lblRes.Text = calc.res.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora(Convert.ToDouble(txtN1.Text), Convert.ToDouble(txtN2.Text));

            calc.subtrair();
            lblRes.Text = calc.res.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora(Convert.ToDouble(txtN1.Text), Convert.ToDouble(txtN2.Text));

            calc.multiplicar();
            lblRes.Text = calc.res.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora(Convert.ToDouble(txtN1.Text), Convert.ToDouble(txtN2.Text));

            calc.dividir();
            lblRes.Text = calc.res.ToString();
        }
    }
}
