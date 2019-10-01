using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarTamanhoDoNome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar o nome a ser calculado: ");
            var nomeLength   = Console.ReadLine();

            Console.WriteLine($"O tamanho deste nome é: {nomeLength.Replace(" ","").Length}");//o replace ignora o que está em parênteses
            Console.ReadKey();  //parar para ver as informações
        }
    }
}
