using Models;
using System;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Ferramentas
{
    public class GravarClientes
    {
        public static void Gravar(Cliente cliente)
        {
            var texto = JsonConvert.SerializeObject(cliente);

            File.WriteAllText(@"c:\Temp\texte.log", texto);
        }

    }
}
