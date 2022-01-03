using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double prova1, prova2, prova3, media;

            prova1 = double.Parse(txtP1.Text);
            prova2 = double.Parse(txtP2.Text);
            prova3 = double.Parse(txtP3.Text);

            media = ((prova1 + prova2 + prova3) / 3);

            if (media < 4)
            {
                MessageBox.Show("Sua média é " + media.ToString("0.00") + " . Logo, você está reprovado! :(", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (media < 7)
            {
                MessageBox.Show("Sua média é " + media.ToString("0.00") + " . Logo, você está de recuperação :(", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("Sua média é " + media.ToString("0.00") + " . Logo, você está aprovado :)", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
        }
    }
}
