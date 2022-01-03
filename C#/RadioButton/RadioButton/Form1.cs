using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (rdbMasc.Checked == true)
            {
                MessageBox.Show("Você selecionou o sexo Masculino!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Você selecionou o sexo Feminino!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
