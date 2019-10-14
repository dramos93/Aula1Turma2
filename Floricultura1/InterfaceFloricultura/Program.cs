using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassFloricultura.Controller;
using ClassFloricultura.Model;

namespace InterfaceFloricultura
{

    class Program
    {
        static FloresController FloresController = new FloresController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;
            bool i;

            while(opcao!=0)
            {
                Console.WriteLine("*****Menu*****");
                Console.WriteLine("1 - Mostrar Flores");
                Console.WriteLine("2 - Adicionar Flor");
                Console.WriteLine("3 - Mostrar Quantidade de Flor");
                Console.WriteLine("4 - Sair");
                i = int.TryParse(Console.ReadLine(), out opcao);
                if (i)
                {
                    switch (opcao)
                    {
                        case 1:
                            OrdenarFlores();
                            break;
                        case 2:
                            AdicionarFlor();
                            break;
                        case 3:
                            TotalFlores();
                            break;
                        case 0:
                            opcao = 0;
                            break;

                        default:
                            //i = int.MinValue;
                            Console.WriteLine("\nVocê Digitou uma opção Inválida, Tente novamente");
                            break;
                    }
                }
                else
                {
                    opcao = int.MinValue;
                    Console.WriteLine("\nVocê Digitou uma opção Inválida, Tente novamente");
                }
            }
        }

        private static void AdicionarFlor()
        {
            Console.WriteLine("Vamos Adicionar um FLor\n");
            Console.Write("Digite o nome da Flor: ");
            var flor = Console.ReadLine();
            Console.Write("\nDigite a Quantidade: ");
            var Qtde = int.Parse(Console.ReadLine());
            var teste = FloresController.AddFlor(new Flores{ Nome=flor, Quantidade=Qtde});
            if(teste)
                Console.WriteLine("\nFlor Cadastrada com Sucesso");
            else
                Console.Write("Não deu certo Cadastrar essa FLor, Volte ao menu e tente novamente..");
        }

        private static void TotalFlores()
        {
            Console.WriteLine( $"A Quantidade Total de Flores é de: {FloresController.SomaDeFlores()}");
            Console.ReadKey();
        }

        private static void OrdenarFlores()
        {
            FloresController.GettFlores().OrderByDescending(x=> x.Quantidade).ToList().ForEach(x => Console.WriteLine($"Id: {x.Id} Flor: {x.Nome} Quantidade: {x.Quantidade}")) ;
            Console.ReadKey();
        }
    }
}
