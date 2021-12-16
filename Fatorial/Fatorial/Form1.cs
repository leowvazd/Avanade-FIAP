using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num, res = 1;

            num = int.Parse(txtNum.Text);

            for (int x = 1; x <= num; x++)
            {
                res *= x;
            }

            MessageBox.Show("O fatorial do número digitado é: " + res + ".", "Mensagem! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
