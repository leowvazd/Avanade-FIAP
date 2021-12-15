using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SituacaoAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double nota1, nota2, media, freq;

            double totalAulas, assistidasAulas;

            string msg;            

            if (double.TryParse(txtN1.Text, out nota1) == false)
            {
                msg = "Por favor, digite uma nota de 0 a 10";
                MessageBox.Show(msg, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN1.Clear();
                txtN1.Focus();
                return;
            }

            if (double.TryParse(txtN2.Text, out nota2) == false)
            {
                msg = "Por favor, digite uma nota de 0 a 10";
                MessageBox.Show(msg, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN2.Clear();
                txtN2.Focus();
                return;
            }

            if (double.TryParse(txtTA.Text, out totalAulas) == false)
            {
                msg = "Por favor, digite uma quantidade válida de aulas";
                MessageBox.Show(msg, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTA.Clear();
                txtTA.Focus();
                return;
            }

            if (double.TryParse(txtAA.Text, out assistidasAulas) == false)
            {
                msg = "Por favor, digite uma quantidade válida de aulas";
                MessageBox.Show(msg, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAA.Clear();
                txtAA.Focus();
                return;
            }

            media = (nota1 + nota2) / 2;
            freq = ((assistidasAulas / totalAulas) * 100);                                                              // em %

            if (media >= 7.00 && freq >= 75.00)
            {
                msg = ("Parabens! Você está aprovado com média: " + media.ToString("0.00") + ". E frequência de: " + freq.ToString() + " %.");
                MessageBox.Show(msg, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                msg = ("Que pena! Você está reprovado com média: " + media.ToString("0.00") + ". E frequência de: " + freq.ToString() + " %.");
                MessageBox.Show(msg, "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
