using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();
        static void Main(string[] args)
        {
            pessoa.AddPessoa(new Pessoa() { Nome = "Abigail"});//Inser um nome no banco de Dados
            Console.WriteLine();
            pessoa.GetPessoas().ToList<Pessoa>().//btemos a lista de Pessoas
                ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            
        }
    }
}
