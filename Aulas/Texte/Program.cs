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
            var text = @"Meu nome é Felipe Junior e minha mãe escolheu colocar 
			Junior em meu nome porque achava legal.";
            var countFind = 0;
            Console.WriteLine("Encontre a palavra de até 3 caracteres:");
            var palavra = Console.ReadLine();

            for (int i = 0; i < text.Length-2; i++)
            {
                var comparar = text[i].ToString() +
                               text[i + 1].ToString() +
                               text[i + 2].ToString();

                if (palavra == comparar) countFind++;
            }
            Console.WriteLine($"Quantidade total de {palavra} {countFind}");
            Console.ReadKey();
        }
    }

}
