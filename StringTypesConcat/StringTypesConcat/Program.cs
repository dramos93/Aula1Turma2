using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTypesConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = "Primeira Parte";
            var teste1 = "Segunda Parte\r Terceira Parte";// \r joga para o início da linha
            Console.WriteLine(teste1+"\n"+teste);
            var testeTemplate = @"Nome do usuario:{0}
Idade:{1}
Descrição:{2}
Hmmmm: {0}";
            var finishText = String.Format(testeTemplate, Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(finishText);//camelcase
            Console.ReadKey();

        }
    }
}
