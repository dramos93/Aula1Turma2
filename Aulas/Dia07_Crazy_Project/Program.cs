using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia07_Crazy_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            IniciarPrograma();
        }
        public static void IniciarPrograma()
        {
            MetodoArvore();
            MetodoCalculoArea();
            MetodoListaCerveja();
            MetodoListaCarro();
        }
        private static void MetodoArvore()
        {

        }private static void MetodoCalculoArea()
        {
            Console.WriteLine("--- Cálculo de Área de um Quadrado ---");
            Console.WriteLine("Digite o valor de um do lado: ");
            var lado = int.Parse(Console.ReadLine());
            lado = lado * lado;
            Console.WriteLine($"\nO valor da área do quadrado é de : {lado} metros");
            Console.ReadKey();
            Console.Clear();
        }private static void MetodoListaCerveja()
        {
            var cervejas = new List<string>()
            { "Brahma", "Skol", "Antartica", "Patagonia", "Original"};
            cervejas.ForEach(nomes => Console.WriteLine(nomes));
            Console.ReadKey();
            Console.Clear();
        }
        private static void MetodoListaCarro()
        {
            var carros = new List<string>()
            { "BMW", "Fiat", "Ford", "Chevrolet", "Kia", "volkswagen", "Mercedes-Benz"};
            carros.ForEach(nomes => Console.WriteLine(nomes));
            Console.ReadKey();
            Console.Clear();
        }

    }
}
