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
    public partial class Frm_Cliente : Form
    {
        public Frm_Cliente()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            bool? Sexo = null;

            if (Rbl_Masculino.Checked)
                Sexo = true;
            else if (Rbl_Feminino.Checked)
                Sexo = false;

            var cliente = new Cliente()
            {
                Cpf = Txt_Cpf.Text,
                Nascimento = DateTime.Parse(Txt_Nascimento.Text),
                Nome = Txt_Nome.Text,
                Masculino = Sexo
            };

            cliente.Gravar();
        }
        private void Rbl_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbl_Masculino.Checked)
            {
                Rbl_Feminino.Checked = false;
                Rbl_NaoBinario.Checked = false;
            }
        }

        private void Rbl_Feminino_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbl_Feminino.Checked)
            {
                Rbl_Masculino.Checked = false;
                Rbl_NaoBinario.Checked = false;
            }
        }

        private void Rbl_NaoBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbl_NaoBinario.Checked)
            {
                Rbl_Masculino.Checked = false;
                Rbl_Feminino.Checked = false;
            }
        }
    }
}
