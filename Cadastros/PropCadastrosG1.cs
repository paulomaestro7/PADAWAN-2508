using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }

    public class Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
    }

    public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
