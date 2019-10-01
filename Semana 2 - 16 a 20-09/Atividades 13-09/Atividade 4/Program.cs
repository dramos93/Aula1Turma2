using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4 - Criar um console app que apresente a quantidade total de
             * caracteres que contém em um texto informado pelo usuário.*/

            Console.WriteLine("Digite um texto qualque que eu te informo quantos caracteres tem teu texto:");
            string texto = Console.ReadLine();

            int quantidade = texto.Length;

            Console.WriteLine($"\nA quantidade de Caracteres nesse texto é de {quantidade}.");
            Console.ReadKey();
        }
    }
}
