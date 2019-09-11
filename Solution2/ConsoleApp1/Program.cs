using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Iniciando uma constante de um número inteiro
        const   int testeConst  =   999;
        
        static void Main(string[] args)
        {
            string  testePrimitivo = string.Empty;          //
            String outroTestePrimitivo  =   string.Empty;   //
            bool    testComp   =   "123"   ==   "123";
            Boolean testeComp   =   "123"   ==   "123";

            var testeFora = string.Empty;
            testeFora = "palavra";
            
            var teste1 = "String(Texto)"; //Texto
            var teste2 = 'C'; //Char
            var teste3 = 8; //Int
            var teste4 = 3.68;  //Double
            var teste5 = 0x0F; //Hex
            //Apresentando a Constante
            Console.WriteLine(testeConst);
            Console.ReadKey();
        }
    }
}
