namespace Grupo_5_WFA.ModelsG5
{
    public class EnderecoG5
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }

        public EnderecoG5()
        {

        }
        public EnderecoG5(string rua, string numero, string complemento, string localidade, string uf)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Localidade = localidade;
            Uf = uf;
        }
    }
}
