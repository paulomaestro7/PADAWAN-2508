using Newtonsoft.Json;
using Padawan_2708_TiposGenericos.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Padawan_2708_TiposGenericos
{
    public partial class Form1 : Form
    {
        private readonly TipoGenrico<string> MinhaListagem;
        private readonly ClienteDados clienteDados;
        public Form1()
        {
            InitializeComponent();
            MinhaListagem = new TipoGenrico<string>();
            clienteDados = new ClienteDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            //MinhaListagem.Add(Txt_Adicionar.Text);
            //var result = MinhaListagem.Result();

            //Txt_Lista.Text = "";

            //result.ForEach(itemLista => {
            //    Txt_Lista.Text += itemLista + Environment.NewLine;
            //});


            clienteDados.Add(new ClienteModel()
            {
                Nome = Txt_Adicionar.Text,
                SobreNome = Txt_Adicionar.Text + " Sobrenome"
            });

            var resultDados =  clienteDados.Result();


            Txt_Lista.Text = "";

            resultDados.ForEach(itemLista => {
                Txt_Lista.Text += itemLista.Nome + " " + itemLista.SobreNome + Environment.NewLine;
            });


            Txt_Adicionar.Text = "";
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {

        }
    }
}
