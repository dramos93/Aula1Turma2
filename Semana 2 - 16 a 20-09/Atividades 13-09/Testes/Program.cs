using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < 20; i++)
            {
                sb.AppendLine(i.ToString());
            }
            System.Console.WriteLine(sb.ToString());
        }
    }
}
