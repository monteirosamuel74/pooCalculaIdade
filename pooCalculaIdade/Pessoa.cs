using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {
		public Pessoa(String nomePessoa, int anoNascPessoa) 
		{
			this.nome = nomePessoa;
			this.anoNascimento = anoNascPessoa;
			this.CalcularIdade();
		}
		private int anoNascimento;

		public int AnoNascimento
		{
			get { return anoNascimento; }
			set { anoNascimento = value; }
		}

		private String nome;

		public String Nome
		{
			get { return nome; }
			set { nome = value.ToUpper(); }
		}

		private int idade;

		public int Idade
		{
			get {
                this.CalcularIdade();
                return idade; }
		}


		public void ExibirDados()
		{
			Console.WriteLine("Nome: " + this.nome);
			Console.WriteLine("Ano de nascimento: " + this.anoNascimento);
			Console.WriteLine("Idade: " + this.Idade);
		}

		private void CalcularIdade()
		{
			DateTime data = DateTime.Now;
			int ano = data.Year;
			this.idade = ano - this.anoNascimento;
		}
	}
}
