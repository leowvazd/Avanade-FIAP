using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanParaVotar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte idade;

            idade = byte.Parse(txtIdade.Text);

            if (idade < 16)
            {
                MessageBox.Show("Você tem " + idade + " anos, logo não pode embarcar e nem votar.", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (idade < 18)
            {
                MessageBox.Show("Você tem " + idade + " anos, logo pode embarcar e votar.", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Você tem " + idade + " anos, logo pode embarcar e deve votar.", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
