using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilizandoFomr2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Esse é um texto qualquer que não tem nada haver porque não entendi nada";
            var countFind = 0;
            Console.WriteLine("Digite um texto: ");
            nome = Console.ReadLine();
            Console.WriteLine("Encontre a palavra de 3 caracteres: ");
            var palavra = Console.ReadLine();

            for (int i = 0; i < (nome.Length - 2); i++)
            {
                var palavraparacomparar = nome[i].ToString() + nome[i + 1].ToString() + nome[i + 2].ToString();
                if (palavra == palavraparacomparar)
                {
                    countFind++;
                }
            }
            Console.WriteLine($"O total de da palavra localizada foi de: {countFind}");
            Console.ReadKey();
        }
    }
}
