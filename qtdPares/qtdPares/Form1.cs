using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qtdPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, dif;

            num1 = int.Parse(txtN1.Text);
            num2 = int.Parse(txtN2.Text);

            dif = num1;
            int pares = 0;

            if (num1 < num2)
            {
                do
                {
                    if (dif % 2 == 0)
                    {
                        pares = pares + 1;
                    }

                    dif++;

                } while (dif <= num2);
            }

            else
            {
                MessageBox.Show("Por favor, digite N1 menor que N2", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtN1.Clear();
                txtN2.Clear();
                txtN1.Focus();
                return;
            }

            MessageBox.Show("A quantidade de números pares entre os números digitados é de: " + pares + ". ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
