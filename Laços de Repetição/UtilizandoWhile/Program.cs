using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            Console.WriteLine("");
            while (count<100)
            {
                Console.WriteLine($"Número:{count+=5}");
                //Console.WriteLine("Número: "+count);
             
            }
            Console.WriteLine("Terminou o loop");
            Console.ReadKey();
        }
    }
}
