using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7 - Criar um console app conte a quantidade de "a","e","i","o" e "u"
             * dentro de um texto informado pelo usuário.*/
            Console.WriteLine("Digite um texto aí: ");
            var texto = Console.ReadLine();

            String[] arrayLinear = new string[5] { "a", "e", "i","o","u"};//new= Nova estância, para ser acessada quando quiser

            List<string> listaLinear = new List<string>
            {
                "Felipe",
                "Giomar",
                    "Euricledson"
            };
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i].ToString()== arrayLinear[0])
                {
                    Console.WriteLine($"\n tem");
                    Console.ReadKey();
                }
            }


        }
    }
}
