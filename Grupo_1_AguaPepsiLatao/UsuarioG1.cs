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
    public partial class UsuarioG1 : Form
    {
        public UsuarioG1()
        {
            InitializeComponent();
        }

        private void btn_GravarUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new Cadastros.Usuario();

            usuario.Login = txt_Login.Text;
            usuario.Senha = txt_Senha.Text;

            CriaArquivoG1.EscreverUsuario(usuario);
        }
    }
}
