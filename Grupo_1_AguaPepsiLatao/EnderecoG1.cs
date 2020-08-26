using CriacaoArquivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_1_AguaPepsiLatao
{
    public partial class EnderecoG1 : Form
    {
        public EnderecoG1()
        {
            InitializeComponent();
        }

        private void btn_GravarEnd_Click(object sender, EventArgs e)
        {
            var endereco = new Cadastros.Endereco();

            endereco.Rua = txt_Rua.Text;
            endereco.Bairro = txt_Bairro.Text;
            endereco.Numero = txt_Numero.Text;
            endereco.Complemento = txt_Complemento.Text;
            endereco.Cidade = txt_Cidade.Text;

            CriaArquivoG1.EscreverEnd(endereco);

        }

        
    }
}
