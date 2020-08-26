using System;

namespace Grupo_5_WFA.Models
{
    internal class EnderecoG5
    {
        private object text1;
        private object text2;
        private object text3;
        private DateTime dateTime;

        public EnderecoG5(object text1, object text2, object text3, DateTime dateTime)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.dateTime = dateTime;
        }
    }
}