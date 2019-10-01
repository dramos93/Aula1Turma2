using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodeBeber
{
    class Program
    {
        public static int idade;
        static void Main(string[] args)
        {

            ShowIntAppText();
            idade = PerguntaIdade();
            RespostaSim();
            RespostaNao();


            //if (PerguntaIdade() >= 18)//a resposta é string, tem que colocar o valor em parenteses
            //{
            //    Console.WriteLine("Você pode Beber!");
            //}
            //else
            //{
            //    Console.WriteLine("Você não pode Beber!");
            //}

            Console.ReadKey();
        }
        /// <summary>
        /// Método para mostrar apenas a mensagem
        /// </summary>
        private static void ShowIntAppText()// Void não retorna um resultado
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja Bem Vindo!--");
            Console.WriteLine("-------------------");
            Console.WriteLine("Digite sua idade: ");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static int PerguntaIdade()
        {
            return int.Parse(Console.ReadLine());//KeyChar é a letra que está escrita
        }
        private static void RespostaSim()
        {
            if (idade >= 18) 
            {
                Console.WriteLine("Você pode Beber!");
            }
        }
        private static void RespostaNao()
        {
            if (idade < 18)
            {
                Console.WriteLine("Você não pode Beber!");
            }
        }

    }
}
