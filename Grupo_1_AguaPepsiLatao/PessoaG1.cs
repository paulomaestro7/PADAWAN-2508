using Cadastros;
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
    public partial class PessoaG1 : Form
    {
        public PessoaG1()
        {
            InitializeComponent();
        }

       

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            var pessoa = new Cadastros.Pessoa();

            pessoa.Nome = txt_Nome.Text;
            pessoa.Sobrenome = txt_Sobrenome.Text;

            CriaArquivoG1.EscreverPessoa(pessoa);
        }
    }
}
