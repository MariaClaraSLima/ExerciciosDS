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
    public partial class frmexercicio1 : Form
    {
        public frmexercicio1()
        {
            InitializeComponent();
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double litros, result;
            string cod;

            litros = Convert.ToDouble(txtlitros.Text);
            cod = Convert.ToString(txtcod.Text);
            if (cod.Equals("A"))
            {
                if (litros <= 20)
                {
                    result = litros * (4.30 - (4.30 * 3 / 100));
                        txtresult.Text = result.ToString();
                }
                else
                {
                    result = litros * (4.30 - (4.30 * 5 / 100));
                    txtresult.Text = result.ToString();
                }
            }
            else
            { 
                if (cod.Equals("G"))
                {
                    if (litros <= 20)
                    {
                        result = litros * (5.20 - (5.20 * 4 / 100));
                        txtresult.Text = result.ToString();
                    }
                    else
                    {
                        result = litros * (5.20 - (5.20 * 6 / 100));
                        txtresult.Text = result.ToString(); 
                    }
            }

                {

                

                }
            }
        }

        private void bntlimpar_Click(object sender, EventArgs e)
        {
            txtlitros.Clear();
            txtcod.Clear();
            txtresult.Clear();

            txtlitros.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu fm = new frmmenu();
            fm.Show();
        }

        private void frmexercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}
