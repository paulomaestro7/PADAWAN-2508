using Solucao_WFA_Padawan.Model;
using Solucao_WFA_Padawan.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Solucao_WFA_Padawan
{
    public partial class Frm_Endereco : Form
    {
        public Frm_Endereco()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            var endereco = new Endereco()
            {
                Cep = Txt_Cep.Text,
                DesEndereco = Txt_Endereco.Text,
                Numero = Txt_Numero.Text
            };

            endereco.Gravar();
        }
    }
}
