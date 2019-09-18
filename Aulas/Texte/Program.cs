using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Cálculo de Área de um Quadrado ---");
            Console.WriteLine("--- Cálculo de Área de um Quadrado ---");
            Console.WriteLine("Digite o valor de um do lado: ");
            var lado = int.Parse(Console.ReadLine());
            lado = lado * lado;
            Console.WriteLine("\nO valor da área do quadrado é de : {lado} metros");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
