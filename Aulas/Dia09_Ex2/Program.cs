using Dia09_Ex2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia09_Ex2
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite uma das opções Abaixo:");
            Console.WriteLine("1 - Lançar Cadastro de Pessoa\n2 - Listar Pessoas Cadastradas\n3 - Sair  ");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CadastoPessoa();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção Inválida: Digite umas das opções abaixo:\n");
                    Menu();
                    break;
            }

        }

        public static void CadastoPessoa()
        {
            var listaDeCadastro = new List<Pessoa>();
            Console.WriteLine("Digite o nome da pessoa: ");
            var nomePessoa = Console.ReadLine();
            Console.WriteLine("Digite o nome da Idade: ");
            int nomePessoa = Console.ReadLine();
            Console.WriteLine("Digite o nome da Sexo: ");
            char nomePessoa = Console.ReadLine();
            Console.WriteLine("Digite o nome da Altura: ");
            double nomePessoa = Console.ReadLine();

            listaDeCadastro.Add(new Pessoa)()
            {
                

            }
        }
    }
}
