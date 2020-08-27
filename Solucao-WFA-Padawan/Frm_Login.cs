using Solucao_WFA_Padawan.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Solucao_WFA_Padawan
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            LerDados.CarregarDados();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Frm_Usuario().ShowDialog();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (LerDados.ListaUsuario != null)
            {
                var usuario = LerDados.ListaUsuario.Where(x => x.Login == Txt_Login.Text).FirstOrDefault();

                if (usuario == null)
                    MessageBox.Show("Usuário não encontrado");
                else
                {
                    if (usuario.Senha == Txt_Senha.Text)
                    {
                        new Frm_Menu().ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Senha inválida");
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }    
        }
    }
}
