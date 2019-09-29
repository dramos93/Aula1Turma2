using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var daniel = "Daniel Silva Ramos";
            var CountFind = 0;
            for (int i = 1; i <= 16; i++) 
            {
                var stringBuilder = $"{daniel[i - 1]}-{daniel[i]}-{daniel[i + 1]}";
                Console.WriteLine(stringBuilder);
                if (stringBuilder.Contains("a-n"))
                {
                    CountFind++;
                }
            }
            Console.WriteLine($"Quantidade total de 'an' {CountFind}");
            Console.ReadKey();
        }
    }
}
