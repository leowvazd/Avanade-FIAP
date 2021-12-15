using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            switch (cmbEscolha.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Você escolheu a Equipe Ferrari!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 1:
                    MessageBox.Show("Você escolheu a Equipe Mercedes!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 2:
                    MessageBox.Show("Você escolheu a Equipe RedBull!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 3:
                    MessageBox.Show("Você escolheu a Equipe McLaren!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    MessageBox.Show("Por favor, selecione uma Equipe!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
