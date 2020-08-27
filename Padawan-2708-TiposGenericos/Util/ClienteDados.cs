using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LiteDB;

namespace Padawan_2708_TiposGenericos.Util
{
    public class ClienteDados
    {
        private readonly ILiteDatabase liteDB;
        public ClienteDados()
        {
            liteDB = new LiteDatabase(@"c:\temp\meubancopadawan.db");
            //var teste = new DirectoryInfo().get
        }

        public void Add(ClienteModel cliente)
        {
            liteDB.GetCollection<ClienteModel>().Insert(cliente);
        }

        public List<ClienteModel> Result()
        {
            return liteDB.GetCollection<ClienteModel>().FindAll().ToList();
        }
    }
}
