using System;
using System.Collections.Generic;
using System.Text;

namespace Solucao_WFA_Padawan.Model
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public bool? Masculino { get; set; }
    }
}
