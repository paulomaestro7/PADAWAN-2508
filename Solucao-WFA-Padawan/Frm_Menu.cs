using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Solucao_WFA_Padawan
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Btn_Cliente_Click(object sender, EventArgs e)
        {
            new Frm_Cliente().ShowDialog();
        }

        private void Btn_Endereco_Click(object sender, EventArgs e)
        {
            new Frm_Endereco().ShowDialog();
        }

        private void Btn_Usuario_Click(object sender, EventArgs e)
        {
            new Frm_Usuario().ShowDialog();
        }
    }
}
