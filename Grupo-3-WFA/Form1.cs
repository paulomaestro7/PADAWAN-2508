using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_3_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.Nome = txt_Nome.Text;
            cliente.Telefone = txt_Telefone.Text;
        }
    }
}
