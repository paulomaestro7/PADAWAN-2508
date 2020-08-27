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
        private readonly TipoGenerico<string> MinhaLista;
        public Form1()
        {
            InitializeComponent();
            MinhaLista = new TipoGenerico<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {

        }
    }
}
