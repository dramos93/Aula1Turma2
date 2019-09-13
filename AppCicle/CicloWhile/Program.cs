using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowIntAppText();

            while (MetodoPergunta() == 1)//a resposta é string, tem que colocar o valor em parenteses
            {

            }

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
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static int MetodoPergunta()
        {
            Console.WriteLine("Vamos Conversar? 1-Sim 2-Não");
            return int.Parse(Console.ReadKey().KeyChar.ToString());//KeyChar é a letra que está escrita

        }
    }
}
