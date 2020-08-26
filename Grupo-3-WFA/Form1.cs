using Ferramentas;
using Models;
using System;
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
            var cliente = new ClienteG3();

            cliente.Nome = txt_Nome.Text;
            cliente.Telefone = txt_Telefone.Text;

            GravarClientesG3.Gravar(cliente);

            txt_Nome.Text = "";
            txt_Telefone.Text = "";

            lbl_Confirma.Text = "Gravado com sucesso!";

            
        }

        private void btn_zerar_Click(object sender, EventArgs e)
        {
            GravarClientesG3.Apagar();
            lbl_Apagar.Text = "Arquivo apagado com sucesso!";
        }

        private void btn_voltarvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
