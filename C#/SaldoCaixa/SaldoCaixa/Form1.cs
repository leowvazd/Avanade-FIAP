using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaldoCaixa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnDepositar_Click(object sender, EventArgs e)
        {
            Banco bank = new Banco(Convert.ToDouble(txtValor.Text));
            bank.depositar();

            lblRes.Text = bank.res.ToString("0.00");

            txtValor.Clear();
            txtValor.Focus();
        }

        public void btnSacar_Click(object sender, EventArgs e)
        {
            Banco bank = new Banco(Convert.ToDouble(txtValor.Text));

            bank.sacar();

            lblRes.Text = bank.res.ToString("0.00");

            txtValor.Clear();
            txtValor.Focus();
        }
    }
}
