using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia07_Crazy_Project;
//using Dia08

namespace dia08_AcessandoInformação
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Dia07_Crazy_Project.Crazy_Project.MetodoCalculoArea();
        }
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite uma das opções abaixa: ");
            Console.WriteLine("1 - Mostrar Árvores\n2 - Calcular Áres\n3 - Listar Cervejas\n4 - Listar Marcas de Carros\n5 - SAIR");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Dia07_MinhaBiblioteca.MetodoArvore();
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    Dia07_MinhaBiblioteca.MetodoCalculoArea();
                    Menu();
                    break;
                case "3":
                    Console.Clear();
                    Dia07_MinhaBiblioteca.MetodoListaCerveja();
                    Menu();
                    break;
                case "4":
                    Console.Clear();
                    Dia07_MinhaBiblioteca.MetodoListaCarro();
                    Menu();
                    break;
                case "5":;
                    Console.Clear();
                    break;

                default: Menu();
                    break;
            }

        }

    }
}