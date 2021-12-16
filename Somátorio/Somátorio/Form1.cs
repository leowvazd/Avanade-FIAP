using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Somátorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, res = 0;

            num1 = int.Parse(txtN1.Text);
            num2 = int.Parse(txtN2.Text);

            if ( num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    res = res + i;
                }

                MessageBox.Show("O somátorio do número digitado é de: " + res + ". ", "Mesagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Por favor, digite N1 menor que N2!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtN1.Clear();
                txtN2.Clear();
                txtN1.Focus();
                return;
            }
        }
    }
}
