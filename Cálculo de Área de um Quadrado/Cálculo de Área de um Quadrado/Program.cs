using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_Área_de_um_Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1 ;          //
            int lado2 ;          //
            int resultado ;          //
            Console.Write("Informe o lado 1: ");
            lado1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o lado 2: ");
            lado2 = int.Parse(Console.ReadLine());
            Console.ReadKey();
            resultado = lado1 * lado2;
            Console.ReadKey();
        }
    }
}
