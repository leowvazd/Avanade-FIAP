using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Viagem
{
    public partial class Form1 : Form
    {
        Percurso p = new Percurso();
        Custos c = new Custos();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {         
            //p.valorPedagio = double.Parse(txtPedagio.Text);
            //p.valorCombustivel = double.Parse(txtCombustivel.Text);
            //p.kmPercorrida = double.Parse(txtKMPercorrida.Text);

            //c.calcularViagem(p);

            //MessageBox.Show($"Custo total: R$ {c.totalPercurso.ToString("0.00")}");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            p.listarPercurso();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            p.cadastrarPercurso();
        }
    }
}
