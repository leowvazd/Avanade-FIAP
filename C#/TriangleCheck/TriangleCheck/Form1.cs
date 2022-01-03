using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckar_Click(object sender, EventArgs e)
        {
            double x, y, z;
            string mensagem = "Por favor, digite números positivos!";


            // tratamento double
            if (double.TryParse(textBox1.Text, out x) == false)
            {
                mensagem = "Por favor, digite um número válido!";
                MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            if (double.TryParse(textBox2.Text, out y) == false)
            {
                mensagem = "Por favor, digite um número válido!";
                MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
                return;
            }

            if (double.TryParse(textBox3.Text, out z) == false)
            {
                mensagem = "Por favor, digite um número válido!";
                MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
                textBox3.Focus();
                return;
            }

            // tratamento negativo
            if (x <= 0)
            {
                mensagem = "Por favor, digite um número positivo!";
                MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
                return;
            }   

            if (y <= 0)
            {
                mensagem = "Por favor, digite um número positivo!";
                MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
                return;
            }

            if (z <= 0)
            {
                mensagem = "Por favor, digite um número positivo!";
                MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
                textBox3.Focus();
                return;
            }

            // condicionais
            if ( x == y && x == z && y == z)
            {
                mensagem = "Triângulo Equilátero!";
                MessageBox.Show(mensagem, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if ((x == y && x == z) || (y == x && y == z) || (z == x && z == y))
            {
                mensagem = "Triângulo Isóceles!";
                MessageBox.Show(mensagem, "Mesagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                mensagem = "Triângulo Isóceles!";
                MessageBox.Show(mensagem, "Mesagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
