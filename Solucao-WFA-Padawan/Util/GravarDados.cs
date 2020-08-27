using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Solucao_WFA_Padawan.Util
{
    public static class GravarDados
    {
        private const string caminho = @"C:\temp\";
        public static bool Gravar(this object Valor)
        {
            try
            {

                var texto = JsonConvert.SerializeObject(Valor);

                if (!Directory.Exists(caminho))
                    Directory.CreateDirectory(caminho);

                var type = Valor.GetType().Name;

                File.AppendAllText($"{caminho}{type}.txt", texto + ",");
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }
    }
}
