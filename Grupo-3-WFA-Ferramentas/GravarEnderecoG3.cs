using Models;
using System;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Net;
using Grupo_3_WFA_Models;

namespace Ferramentas
{
    public class GravarEnderecoG3
    {
        public static void Gravar(EnderecoG3 endereco)
        {
            var texto = JsonConvert.SerializeObject(endereco);



            using (StreamWriter writer = new StreamWriter(@"C:\Teste\cdEndereco.txt", true))
            {
                writer.WriteLine(texto);
            }

        }

        public static void Apagar()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Teste\cdEndereco.txt"))
            {
            }
        }

    }

   
}
