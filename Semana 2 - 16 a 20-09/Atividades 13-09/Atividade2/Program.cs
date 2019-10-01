using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2 - Criar um console app que apresente as boas vindas, 
             * solicite o nome do usuário. completo e
             * mostre uma mensagem de boas vindas com o nome do usuário.*/
            Console.WriteLine("Digite seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            var nome = new System.Text.StringBuilder();

            //string[] vetor = new string[5]; Criação de Array/Vetor
            //

            for (int i = 0;nomeCompleto[i].ToString() != " "; i++)
            {
               

                nome.Append(nomeCompleto[i].ToString());
                
            }
            Console.WriteLine("");
            Console.WriteLine($"Seja Bem Vindo: {nome}");
            Console.ReadKey();
        }
    }
}
