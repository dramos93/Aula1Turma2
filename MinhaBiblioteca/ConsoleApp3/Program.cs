using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dadosbiblioteca.Controller;
using Dadosbiblioteca.Model;

namespace ConsoleApp3
{
    class Program
    {
        public static LivrosController livrosController = new LivrosController();
        static void Main(string[] args)
        {
            MenuPincipal();
        }
        /// <summary>
        /// Menu Principal
        /// </summary>
        private static void MenuPincipal()
        {
            Console.WriteLine("1 - Mostrar Livros");
            Console.WriteLine("2 - Adicionar Livros");
            Console.WriteLine("0 - Sair");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    Menuum();
                    break;
                case 2:
                    Console.Clear();
                    Menudois();
                    break;
                case 3:
                    Console.Clear();
                    MenuTres();
                    break;
                case 0: break;
                default:
                    Console.WriteLine("\nVocê digitou uma opção inválida, escolha novamente:\n");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPincipal();
                    break;
            }
            Console.Clear();
        }

        private static void MenuTres()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Menu Responsável por Mostrar todas as listas de livros
        /// </summary>
        private static void Menudois()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Livro");
            Console.WriteLine("Digite o Título do Livro: ");

            livrosController.AdicionarLivro(new Livros { NomeLivro = Console.ReadLine()});

            Console.WriteLine("\nLivro Adicionado com Sucesso!");
            Console.ReadLine();
            MenuPincipal();
        }

        /// <summary>
        /// Menu 1
        /// </summary>
        private static void Menuum()
        {
            Console.WriteLine("1 - Livros Disponíveis");
            Console.WriteLine("2 - Livros Alugados");
            Console.WriteLine("3 - Livros Todos Existentes");
            Console.WriteLine("4 - Livros Excluídos");
            Console.WriteLine("0 - Voltar ao Menu Principal");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Livros Disponíveis para Empréstimo\n");
                    DisponibilidadeLivros(true);
                    Console.ReadKey();
                    Console.Clear();
                    Menuum();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Livros Indisponíveis para Empréstimo\n");
                    DisponibilidadeLivros(false);
                    Console.ReadKey();
                    Console.Clear();
                    Menuum();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Todos os Livros Existentes\n");
                    TodosLivros();
                    Console.ReadKey();
                    Console.Clear();
                    Menuum();
                    break;
                case 0:
                    Console.Clear();
                    MenuPincipal();
                    break;
                default:
                    Console.WriteLine("\nVocê digitou uma opção inválida, escolha novamente:\n");
                    Menuum();
                    break;
            }
        }

        /// <summary>
        /// Aqui mostra todos livros que existema, tanto disponível ou alugado
        /// </summary>
        /// <param name="opcao">aqui recebe qual foi a opção que o usuário escolheu</param>
        public static void DisponibilidadeLivros(bool opcao)
        {
            livrosController.MostrarLivrosDisponiveis(opcao).ForEach(i => Console.WriteLine($"Id:{i.IdLivro} | Situação:  {Diponibilidade(i.LivroAtivo)} | Título: {i.NomeLivro}"));
        }
        
        /// <summary>
        /// Mostrar Todos os livros
        /// </summary>
        public static void TodosLivros()
        {
            livrosController.MostrarListaLivros().ForEach(i => Console.WriteLine($"Id:{i.IdLivro} | Situação: {Diponibilidade(i.LivroAtivo)} | Título: {i.NomeLivro}"));
        }

        /// <summary>
        /// Método que retorna se o livro está disponível ou não
        /// </summary>
        /// <param name="livros">Entra o valor verdadeiro ou falso</param>
        /// <returns>Retorna a disponibilidade do livro</returns>
        private static string Diponibilidade(bool livros)
        {
            if (livros == true)
                return "Disponível";
            else
                return "Indisponível";
        }
        /// <summary>
        /// Mostra Livros excluídos
        /// </summary>
        public static void LivrosExcluídos()
        {

        }



    }
}
