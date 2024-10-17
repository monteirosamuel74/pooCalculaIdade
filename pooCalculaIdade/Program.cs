using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa idade");
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            int anoNasc = Convert.ToInt32(Console.ReadLine());
            Pessoa pessoa = new Pessoa(nome, anoNasc);
            pessoa.ExibirDados();
            Console.ReadKey();
        }
    }
}
