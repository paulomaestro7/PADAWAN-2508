using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Grupo_5_WFA
{
    public partial class FormClienteG5 : Form
    {
        public FormClienteG5()
        {
            InitializeComponent();
        }

		private void btn_GravarCliente_Click(object sender, EventArgs e)
		{
            var caminho = "C:\\Users\\karina.caetano\\Desktop\\Clientes.txt";
            var cliente = new Models.ClienteG5(
                txt_NomeCliente.Text,
                txt_SobrenomeCliente.Text,
                txt_CpfCliente.Text,
				Convert.ToDateTime(txt_DataNascimentoCliente.Text));

            using (StreamWriter writer = new StreamWriter(caminho, true)) 
            {
                var texto = JsonConvert.SerializeObject(cliente);
                writer.WriteLine(texto);
            }
            
            this.Close();
        }

        private void FormClienteG5_Load(object sender, EventArgs e)
        {

        }
    }
}
