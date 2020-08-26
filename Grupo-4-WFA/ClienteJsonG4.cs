using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Grupo_4_WFA
{
    public class ClienteJsonG4
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }

        public void Escrever(ClienteJsonG4 cliente)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\\Cliente.txt", true))
            {
                var texto = JsonConvert.SerializeObject(cliente);
                writer.WriteLine(texto);
            }
        }

    }

}
