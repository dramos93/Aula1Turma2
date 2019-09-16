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
            // para criar várias variáveis ao mesmo tempo tem que separa com vírgula e tem que por algum valor pra elas
            // char tem que ser entre apóstrofos e deve conter algum valor. ex.: espaço
            char primeira = texto[0];
            char ultima = texto[quantidade-1];
            Console.WriteLine($"A primeira letra é '{primeira}' e a última é: '{ultima}'");
            Console.ReadKey();
        }
    }
}
