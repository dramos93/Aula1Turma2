using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiBlioteca;

namespace Amiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste();
            Menu();

        }


        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite uma das opções abaixo: ");
            Console.WriteLine("1 - Mostrar Árvores\n2 - Calcular Área\n3 - Listar Cervejas\n4 - Listar Marcas de Carros\n5 - SAIR");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    MinhaBiblioteca.MinhaBiblioteca01.CriandoArvore();
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    MinhaBiblioteca.MinhaBiblioteca01.CalculoDeAreaQuadrado();
                    Menu();
                    break;
                case "3":
                    Console.Clear();
                    MinhaBiblioteca.MinhaBiblioteca01.ListaCervejas();
                    Menu();
                    break;
                case "4":
                    Console.Clear();
                    MinhaBiblioteca.MinhaBiblioteca01.ListaCarros();
                    Menu();
                    break;
                case "5":
                    ;
                    Console.Clear();
                    break;

                default:
                    Menu();
                    break;
            }

        }
    }
}
