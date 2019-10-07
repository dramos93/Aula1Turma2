using EntityClass.Controller;
using EntityClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlunos
{
    class Program
    {
        static AlunosController alunos = new AlunosController();
        static void Main(string[] args)
        {
            alunos.AddAluno(new Aluno { Nome = "Feijão", Idade = 48 });

            alunos.GetAlunos().ToList<Aluno>().ForEach(i => Console.WriteLine($"Nome: {i.Nome} Idade: {i.Idade}"));
            Console.ReadKey();
        }
    }
}
