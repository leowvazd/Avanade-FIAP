using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfSimples
{
    public partial class Form1 : Form
    {
        byte idade;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            idade = Convert.ToByte(txtIdade.Text);
        }

        private void bntVerificar_Click(object sender, EventArgs e)
        {
            if (idade >= 12)
            {
                MessageBox.Show("Você pode jogar! :)", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Você não pode jogar! :(", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
