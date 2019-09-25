using BaseDadosVendas.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRelatorios

{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("Digite uma das opções Abaixo: ");
            Console.WriteLine("1 - Apresentar todos os dados: ");


            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    //Parei Aqui, Criar um método que mostra as Vendas
                    Menu();
                    break;
                default:
                    break;
            }
        }
    }
}
