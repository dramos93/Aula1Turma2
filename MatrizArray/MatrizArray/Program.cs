using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizArray
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arrayLinear = new string[3] { "Felipe", "Giomar", "Euricledson" };//new= Nova estância, para ser acessada quando quiser

            List<string> listaLinear = new List<string>
            {
                "Felipe",
                "Giomar",
                    "Euricledson"
            };

            Console.WriteLine(arrayLinear[1]);
            Console.WriteLine(listaLinear[1]);
            Console.ReadKey();//Key lê uma tecla, para pegar qual tecla, coloca-sse .keychar.ToString()
        }
    }
}
