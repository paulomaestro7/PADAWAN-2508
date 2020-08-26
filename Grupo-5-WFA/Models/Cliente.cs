using System;
using System.IO;

namespace Grupo_5_WFA.Models
{
	public class Cliente
	{
		public string Nome { get; set; }
		public string Sobrenome { get; set; }
		public string Cpf { get; set; }
		public DateTime DataNascimento  { get; set; }

		public Cliente(string nome, string sobrenome, string cpf, DateTime dataNascimento)
		{
			Nome = nome;
			Sobrenome = sobrenome;
			Cpf = cpf;
			DataNascimento = dataNascimento;
		}
	}
}
