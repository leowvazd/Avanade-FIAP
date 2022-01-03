using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lacoRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            int num, res;

            num = int.Parse(txtNum.Text);

            lstTabuada.Items.Clear();

            res = num * 1;
            lstTabuada.Items.Add(res.ToString());

            res = num * 2;
            lstTabuada.Items.Add(res.ToString());

            res = num * 3;
            lstTabuada.Items.Add(res.ToString());

            res = num * 4;
            lstTabuada.Items.Add(res.ToString());

            res = num * 5;
            lstTabuada.Items.Add(res.ToString());

            res = num * 6;
            lstTabuada.Items.Add(res.ToString());

            res = num * 7;
            lstTabuada.Items.Add(res.ToString());

            res = num * 8;
            lstTabuada.Items.Add(res.ToString());

            res = num * 9;
            lstTabuada.Items.Add(res.ToString());

            res = num * 10;
            lstTabuada.Items.Add(res.ToString());
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();

            int num, res, i = 1;

            num = int.Parse(txtNum.Text);

            while (i <= 10)
            {
                res = num * i;
                lstTabuada.Items.Add(res.ToString());
                i++;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int num, res;

            num = int.Parse(txtNum.Text);

            for (int i = 1; i <= 10; i++)
            {
                res = num * i;
                lstTabuada.Items.Add(res.ToString());
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int num, res, i = 1;

            num = int.Parse(txtNum.Text);

            do
            {
                res = num * i;
                lstTabuada.Items.Add(res.ToString());
                i++;
            } while (i <= 10);
        }
    }
}
