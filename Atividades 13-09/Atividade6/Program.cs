using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6 - Criar um console app que quando informado o texto
             * contendo banana ele troque esta informação por laranja.*/
            Console.WriteLine("Digite um texto que substituiremos banana por laranja");
            var texto = Console.ReadLine().Replace("banana", "laranja");
            Console.WriteLine($"\n\n{texto}");
            Console.ReadKey();
        }
    }
}
