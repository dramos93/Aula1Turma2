using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia06_1 //Aqui esté o nome do projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informar texto: ");
            var texto = Console.ReadLine();
            var count = 0;
            while(count < texto.Length)
            {
                Console.WriteLine(texto[count]);
                count++;
            }
            Console.ReadKey();
            Console.Clear();
            for (count = 0; count < texto.Length; count++)
            {
                Console.WriteLine(texto[count]);
            }
            Console.ReadKey();
        }
    }
}
