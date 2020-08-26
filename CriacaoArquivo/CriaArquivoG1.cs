using Cadastros;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoArquivo
{
    public class CriaArquivoG1
    {
        public static void EscreverPessoa (Pessoa pessoa)
        {                                                                                                              //o true faz com que novas informações sejam adicionadas ao arquivo, sem apagar as antigas. Caso seja false, ele sorescreve
            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\isabela.aguiar\\Desktop\\Pessoa.txt", true)) //deixar sempre duas barras para funcionar no linux tb
            {
                var novaPessoa = JsonConvert.SerializeObject(pessoa); //serialize - objeto para texto json

                writer.WriteLine(novaPessoa);
            }
        }
        public static void EscreverEnd (Endereco endereco)
        {                                                                                                              //o true faz com que novas informações sejam adicionadas ao arquivo, sem apagar as antigas. Caso seja false, ele sorescreve
            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\isabela.aguiar\\Desktop\\Endereco.txt", true)) //deixar sempre duas barras para funcionar no linux tb
            {
                var novoEnd = JsonConvert.SerializeObject(endereco); //serialize - objeto para texto json

                writer.WriteLine(novoEnd);
            }
        }
        public static void EscreverUsuario(Usuario usuario)
        {                                                                                                              //o true faz com que novas informações sejam adicionadas ao arquivo, sem apagar as antigas. Caso seja false, ele sorescreve
            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\isabela.aguiar\\Desktop\\Usuario.txt", true)) //deixar sempre duas barras para funcionar no linux tb
            {
                var novoUsuario = JsonConvert.SerializeObject(usuario); //serialize - objeto para texto json

                writer.WriteLine(novoUsuario);
            }
        }
        //Mudar o endereço do arquivo a ser criado de acordo com a necessidade

    }
}
