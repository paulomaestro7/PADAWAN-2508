using System;
using System.Windows.Forms;

namespace Grupo_4_WFA
{
    public partial class CadastroClienteG4 : Form
    {
        public CadastroClienteG4()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteJsonG4();
            cliente.Nome = txt_Nome.Text;
            cliente.Cpf = txt_Cpf.Text;
            cliente.DataNasc = date_Nascimento.Value;
            cliente.Escrever(cliente);
        }
    }
}
