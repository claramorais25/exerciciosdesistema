using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Novo arquivo criado!");
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Novo arquivo criado!");
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Novo arquivo criado!");
        }


        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em construção");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em construção");
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}