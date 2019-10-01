using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia06_2_IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplit();
        }
        /// <summary>
        /// Método que mostra como podemos utilizae o foreach para andar sobre
        /// uma array de caracteres, ou seja, um texto ou palabra, etc..
        /// </summary>
        private static void InciandoForeach01()

        {
            Console.WriteLine("Informar o texto: ");
            var conteudoTexto = Console.ReadLine();
            foreach (var item in conteudoTexto) //
            {
                if (item == 'e')
                    continue;//Aqui ele pula o que está abaixo dele.
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        private static void ForeachComSplit()
        {
            var conteudoTexto = "Aqui vou colocar meu nome Felipe para realizar a busca";
            Console.WriteLine("Informe a palavra para realizar a busca> ");
            var palavra = Console.ReadLine();
            var conteudoTextoSplit = conteudoTexto.Split(' ');// Quebra a informação por espaço.
            foreach (var item in conteudoTextoSplit)
            {
                if (palavra==item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }
            Console.ReadKey();
        }
    }
}
