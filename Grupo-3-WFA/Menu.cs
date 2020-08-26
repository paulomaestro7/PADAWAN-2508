using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grupo_3_WFA
{
    public partial class Menu : Form

    {
        Form1 cliente = new Form1();
        TelaEndereco endereco = new TelaEndereco();
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            

            cliente.ShowDialog();
            

        }

        private void btn_endereco_Click(object sender, EventArgs e)
        {
            endereco.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
