using Models;
using System;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Net;

namespace Ferramentas
{
    public class GravarClientesG3
    {
        public static void Gravar(ClienteG3 cliente)
        {
            var texto = JsonConvert.SerializeObject(cliente);



            using (StreamWriter writer = new StreamWriter(@"C:\Users\gabriel.dainezi\Desktop\texto.txt", true))
            {
                writer.WriteLine(texto);
            }

        }

        public static void Apagar()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\gabriel.dainezi\Desktop\texto.txt"))
            {
            }
        }

    }
}
