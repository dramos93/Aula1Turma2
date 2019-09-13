using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 - Criar um console app que apresente o primeiro e o ultimo caractere de uma palavra informada.

            Console.WriteLine("Digite alguma coisa: ");
            var texto = Console.ReadLine();
            int quantidade = texto.Length;
            char primeira, ultima;
            int b=0; 
            for (int i = 0; i < quantidade; i++)
            {
                if (i==0)//se for a primeira letra, salva na primeira
                {
                    primeira = texto[i];
                }
                b = i;
            }
            ultima = texto[b];
            Console.WriteLine($"A primeira letra é '{primeira}' e a segunda é: '{ultima}'");
            Console.ReadKey();
        }
    }
}
