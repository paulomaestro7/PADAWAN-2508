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
using Newtonsoft.Json;
using PADAWAN_NEGOCIO.NEGOCIO;

namespace PADAWAN_TESTE_NINJA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            var result = new NegocioCadastro();

            var resultPrint = result.teste();


            txt_Nome.Text = resultPrint.Nome;
            txt_Sobre.Text =  resultPrint.Sobrenome;

            txt_ResultJson.Text = JsonConvert.SerializeObject(resultPrint);

            File.WriteAllText(@"c:\Temp\texte.log", txt_ResultJson.Text);
        }
    }
}
