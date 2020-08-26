using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo_2_WFA.Entitys
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Contato { get; set; }
    }

    enum TipoContato
    {
        Celular, Email, Telefone
    }

}
