using Ferramentas;
using Grupo_3_WFA_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grupo_3_WFA
{
    public partial class TelaEndereco : Form
    {
        public TelaEndereco()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            EnderecoG3 endereco = new EnderecoG3();

            endereco.CEP = txt_cep.Text;
            endereco.Rua = txt_rua.Text;
            endereco.Numero = txt_numero.Text;
            endereco.Bairro = txt_bairro.Text;
            endereco.Complemento = txt_complemento.Text;
            endereco.Cidade = txt_cidade.Text;
            endereco.Estado = txt_estado.Text;
            endereco.Pais = txt_pais.Text;

            GravarEnderecoG3.Gravar(endereco);

            txt_cep.Text = "";
            txt_rua.Text = "";
            txt_numero.Text = "";
            txt_bairro.Text = "";
            txt_complemento.Text = "";
            txt_cidade.Text = "";
            txt_estado.Text = "";
            txt_pais.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
