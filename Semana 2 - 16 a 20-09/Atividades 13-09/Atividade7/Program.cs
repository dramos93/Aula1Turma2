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
            int letraA = 0, letraE = 0, letraI = 0, letraO = 0, letraU = 0;

            String[] arrayLinear = new string[5] { "a", "e", "i","o","u"};//new= Nova estância, para ser acessada quando quiser

            List<string> listaLinear = new List<string>
            {
                "a",
                "b",
                    "c"
            };
            for (int i = 0; i < texto.Length; i++)
            {
                switch (texto[i])
                {
                    case ('a')  : letraA++;
                        break;
                    case ('e'):
                        letraE++;
                        break;
                    case ('i'):
                        letraI++;
                        break;
                    case ('o'):
                        letraO++;
                        break;
                    case ('u'):
                        letraU++;
                        break;
                    default : 
                        break;
                }
            }


        }
    }
}
