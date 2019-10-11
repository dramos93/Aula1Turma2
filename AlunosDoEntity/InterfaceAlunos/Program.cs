using ClassAlunos.Controller;
using ClassAlunos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlunos
{
    class Program
    {
        static AlunosController AlunosController = new AlunosController();
        static void Main(string[] args)
        {
            Menu();

        }

        private static void Menu()
        {
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Mostrar Alunos");
            Console.WriteLine("2 - Adicionar Alunos");
            char opcao = Console.ReadKey().KeyChar;
            if (opcao == '0')
                Console.Clear();
            if (opcao == '1')
                MostrarAlunos();
            if(opcao == '2')
                AdicionarAluno();
            else
            {
                Console.WriteLine("VOcê Digitou Errado, Digite Novamente");
                Menu();
            }
        }

        private static void MostrarAlunos()
        {
            Console.Clear();
            Console.WriteLine("Alunos Cadastrados");
            AlunosController.GetAlunos().ToList<Alunos>().ForEach(i => Console.WriteLine($"Aluno: {i.Id} Nome: {i.Nome} Idade: {i.Idade}"));
            Console.ReadKey();
            Console.Clear();
        }

        private static void AdicionarAluno()
        {
            Console.Clear();
            Console.WriteLine("Digite o Nome do Aluno: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade do Aluno: ");
            int idade = int.Parse(Console.ReadLine());
            AlunosController.AddPessoa(new Alunos() { Nome = nome, Idade = idade });
            Console.WriteLine("\nAluno Cadastrado Com Sucesso");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }
}
