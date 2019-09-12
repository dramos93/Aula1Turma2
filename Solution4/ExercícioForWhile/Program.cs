using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioForWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informa a palavra de busca: ");
            var wordCount = FindByFor(Console.ReadLine());

            Console.WriteLine($"Encontrados: {wordCount}");
            Console.ReadKey();
        }
        /// <summary>
        /// Método de busca dentro da Aplicação
        /// </summary>
        /// <param name="wordFind">Parâmetros de até 3 caracteres</param>
        /// <returns>Retorna a quantidade encontrada da expressão</returns>
        private static  int FindByFor(string wordFind)
        {
            var contentToFind = TextContent();
            var lengthText = contentToFind.Length-2;
            var contWordFind = 0;
            int i = 0;
            while (i < lengthText)
            {
                var compareWord = contentToFind[i].ToString() +
                                    contentToFind[i + 1].ToString() +
                                    contentToFind[i + 2].ToString();
                if (wordFind == compareWord)
                    contWordFind++;
                i++;
            }
            return contWordFind;
        }
        /// <summary>
        /// Esse método retorna um texto grande para analisar
        /// </summary>
        /// <returns>O conteúdo do texto em string</returns>
        private static  string  TextContent()
        {
            return @"Felipe";
        }

    }
}
