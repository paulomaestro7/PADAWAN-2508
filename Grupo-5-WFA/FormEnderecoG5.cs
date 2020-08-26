using Grupo_5_WFA.ModelsG5;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Grupo_5_WFA
{
    public partial class FormEnderecoG5 : Form
    {
        public FormEnderecoG5()
        {
            InitializeComponent();
        }

        private void FormEnderecoG5_Load(object sender, EventArgs e)
        {

        }

        private void btn_GravarEndereco_Click(object sender, EventArgs e)
        {
            var caminho = "C:\\Users\\karina.caetano\\Desktop\\Endereco.txt";
            var endereco = new EnderecoG5(
                txt_Rua.Text,
                txt_Numero.Text,
                txt_Complemento.Text,
                txt_Localidade.Text,
                txt_UF.Text);


            using (StreamWriter writer = new StreamWriter(caminho, true))
            {
                var texto = JsonConvert.SerializeObject(endereco);
                writer.WriteLine(texto);
            }
            this.Close();
        }
    }
}
