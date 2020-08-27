using Newtonsoft.Json;
using Solucao_WFA_Padawan.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Solucao_WFA_Padawan.Util
{
    public static class LerDados
    {
        private const string caminho = @"C:\temp\";

        public static List<Usuario> ListaUsuario;

        public static bool CarregarDados()
        {
            try
            {
                var usuario = "[" + File.ReadAllText($"{caminho}Usuario.txt") + "]";

                ListaUsuario = JsonConvert.DeserializeObject<List<Usuario>>(usuario);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
