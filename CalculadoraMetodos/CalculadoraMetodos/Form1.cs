using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();

            calc.n1 = double.Parse(txtN1.Text);
            calc.n2 = double.Parse(txtN2.Text);

            calc.somar();

            lbl4.Text = calc.res.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();

            calc.n1 = double.Parse(txtN1.Text);
            calc.n2 = double.Parse(txtN2.Text);

            calc.subtrair();

            lbl4.Text = calc.res.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();

            calc.n1 = double.Parse(txtN1.Text);
            calc.n2 = double.Parse(txtN2.Text);

            calc.multiplicar();

            lbl4.Text = calc.res.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();

            calc.n1 = double.Parse(txtN1.Text);
            calc.n2 = double.Parse(txtN2.Text);

            calc.dividir();

            lbl4.Text = calc.res.ToString();
        }
    }
}
