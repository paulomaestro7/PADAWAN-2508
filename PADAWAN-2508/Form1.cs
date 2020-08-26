using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PADAWAN_2508
{
    public partial class Form1 : Form
    {
        string operador;
        int a = 0;
        bool validar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_Conta.Text += (int)Numeros.um;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_Conta.Text += (int)Numeros.dois;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_Conta.Text += (int)Numeros.tres;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_Conta.Text += (int)Numeros.quatro;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_Conta.Text += (int)Numeros.cinco;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_Conta.Text += (int)Numeros.seis;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_Conta.Text += (int)Numeros.sete;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_Conta.Text += (int)Numeros.oito;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_Conta.Text += (int)Numeros.nove;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_Conta.Text = "";
            txt_Resultado.Text = "";
            a = 0;
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToInt32(txt_Conta.Text);
                txt_Resultado.Text = Convert.ToString(a) + "/";
                txt_Conta.Text = "";
                operador = "/";
            }
            else
            {
                txt_Resultado.Text = txt_Conta.Text + btn_Dividir.Text;
                a = Convert.ToInt32(txt_Conta.Text);
                txt_Conta.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(txt_Conta.Text);
                txt_Resultado.Text = Convert.ToString(a) + "*";
                txt_Conta.Text = "";
                operador = "*";
            }
            else
            {
                txt_Resultado.Text = txt_Conta.Text + btn_Multiplicar.Text;
                a = Convert.ToInt32(txt_Conta.Text);
                txt_Conta.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btn_Mais_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(txt_Conta.Text);
                txt_Resultado.Text = Convert.ToString(a) + "+";
                txt_Conta.Text = "";
                operador = "+";
            }
            else
            {
                txt_Resultado.Text = txt_Conta.Text + btn_Mais.Text;
                a = Convert.ToInt32(txt_Conta.Text);
                txt_Conta.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btn_Menos_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(txt_Conta.Text);
                txt_Resultado.Text = Convert.ToString(a) + "-";
                txt_Conta.Text = "";
                operador = "-";
            }
            else
            {
                txt_Resultado.Text = txt_Conta.Text + btn_Menos.Text;
                a = Convert.ToInt32(txt_Conta.Text);
                txt_Conta.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btn_Resultado_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_Conta.Text += (int)Numeros.zero;
        }
    }
    enum Numeros
    {
        zero = 0,
        um = 1,
        dois = 2,
        tres = 3,
        quatro = 4,
        cinco = 5,
        seis = 6,
        sete = 7,
        oito = 8,
        nove = 9
    }
}
