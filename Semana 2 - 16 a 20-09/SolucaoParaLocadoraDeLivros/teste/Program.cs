using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Daniel";
            Console.WriteLine(string.Format("Nome: {0,10}", nome));
            Console.ReadKey();
        }
    }
}
