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
    public partial class Frm_Usuario : Form
    {
        public Frm_Usuario()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario()
            {
                Nome = Txt_Nome.Text,
                Login = Txt_Usuario.Text,
                Senha = Txt_Senha.Text
            };

            usuario.Gravar();

            LerDados.CarregarDados();

            this.Close();
        }
    }
}
