using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using PADAWAN_DADOS.CONSULTA;
using PADAWAN_DADOS.DADOS;
using PADAWAN_NEGOCIO.Dto;

namespace PADAWAN_NEGOCIO.NEGOCIO
{
    public class NegocioCadastro
    {
        public class Colher
        {
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
        }

        public Colher teste()
        {
            Colher Garfo = new Colher();
            Garfo.Nome = "Paulo ";
            Garfo.Sobrenome = "Maestro";

            return Garfo;
        }
    }
}
