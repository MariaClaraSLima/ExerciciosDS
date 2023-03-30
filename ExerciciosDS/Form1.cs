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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void exercício1CombustívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmexercicio1 fm = new frmexercicio1();
            fm.Show();

        }

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }

        private void exercicio1LoopingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmexercicio2 fm = new frmexercicio2();
            fm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
