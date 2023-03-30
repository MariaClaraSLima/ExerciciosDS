using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosDS
{
    public partial class frmexercicio2 : Form
    {
        public frmexercicio2()
        {
            InitializeComponent();
        }

        private void btncalcularwhile_Click(object sender, EventArgs e)
        {
            int num, result, i; 

            num=Convert.ToInt32(txtnum.Text);

            i = 0;
            while (i<=10) {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text,"\r\n", result.ToString());
                i++;

            }
        }

        private void btncalculardowhile_Click(object sender, EventArgs e)
        {
            int num, result, i;

            num = Convert.ToInt32(txtnum.Text);

            i = 0;
            do
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;
            } while (i <= 10);
        }

        private void btncalcularfor_Click(object sender, EventArgs e)
        {
            int num, result, i;

            num = Convert.ToInt32(txtnum.Text);

            for (i = 0; i <= 10; i++)
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();

            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu fm = new frmmenu();
            fm.Show();
        }
    }
}
