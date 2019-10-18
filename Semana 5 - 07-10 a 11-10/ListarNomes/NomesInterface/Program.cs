using Nomes.Controller;
using Nomes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomesInterface
{
    class Program
    {
        static NomesController NomesController = new NomesController();
        static void Main(string[] args)
        {
                int n = int.MinValue;//a variável opcao vai começar com um valor que é maior que zero, pode ser qualquer valor

            while (n != 0)
            {
                Console.Clear();
                Console.WriteLine("--------------MENU---------------");
                Console.WriteLine("1 - Adicionar Nome");
                Console.WriteLine("2 - Mostrar Nomes");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("---------------------------------");

                Console.Write("\nEscolha uma das opções Acima: ");

                var opcao = int.TryParse(Console.ReadLine(), out n);
                if (opcao)
                {
                    Console.Clear();

                    switch (n)
                    {
                        case 1:
                            AdicionarNome();
                            break;
                        case 2:
                            MostrarNome();
                            break;
                        case 0:;
                            break;
                        default:
                            Erro();
                            break;
                    }
                }
                else
                {
                    n = int.MinValue;
                    Erro();
                }
            }
        }

        private static void Erro()
        {
            Console.WriteLine("\nOpção Inválida, Tente Novamente!");
            Console.Write("\nClique em Qualquer Tecla Para Voltar ao Menu...");
            Console.ReadKey();
        }

        /// <summary>
        /// Método que mostra os nome que tem no Banco de Dados
        /// </summary>
        private static void MostrarNome()
        {
            NomesController.ListarNomes().ToList().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}"));
            Console.Write("\nClique em Qualquer Tecla Para Voltar ao Menu...");
            Console.ReadKey();
        }

        /// <summary>
        /// Método que Adiciona um nome ao meu Banco de Dados
        /// </summary>
        private static void AdicionarNome()
        {
            Console.WriteLine("Digite um novo Nome: ");
            var nome = Console.ReadLine();

            var retorno = NomesController.AdicionarNome(new Name{ Nome = nome });
            if (retorno)
                Console.WriteLine("\nNome Adicionado com Sucesso");
            else
                Console.WriteLine("\nErro ao Adicionar Nome, Tente Novamente");
            Console.Write("\nClique em Qualquer Tecla Para Voltar ao Menu...");
            Console.ReadKey();
        }
    }
}