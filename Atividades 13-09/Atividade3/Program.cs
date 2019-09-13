using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3 - Criar um console app que solicite o nome e a idade, e 
             * após informar nome e idade o mesmo deverá apresentar quando 
             * maior ou igual a 18 anos a seguinte informação: "Parabéns {nome} você já esta na fase adulta."
             * caso menor de 18 anos o mesmo deverá apresentar a seguinte informação:
             * "Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade."*/
            Console.WriteLine("Digite seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade>=18)
            {
                Console.WriteLine($"Parabéns {nome}, você já está na fase adulta");
            }
            else
            {
                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");
            }
            Console.ReadKey();

        }
    }
}
