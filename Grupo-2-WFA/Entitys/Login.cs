using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo_2_WFA.Entitys
{
    public class Login
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

    }
    enum Status
    {
        ativo, inativo
    }
}
