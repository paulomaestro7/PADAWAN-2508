using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grupo_5_WFA.Models;
using Newtonsoft.Json;

namespace Grupo_5_WFA
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

		private void btn_GravarCliente_Click(object sender, EventArgs e)
		{
            var caminho = "C:\\Users\\andre.ando\\Desktop\\Birulable.txt";
            var cliente = new Models.Cliente(
                txt_NomeCliente.Text,
                txt_SobrenomeCliente.Text,
                txt_CpfCliente.Text,
				Convert.ToDateTime(txt_DataNascimentoCliente.Text));

            using (StreamWriter writer = new StreamWriter(caminho, true)) 
            {
                var texto = JsonConvert.SerializeObject(cliente);
                writer.WriteLine(texto);
            }
        }
	}
}
