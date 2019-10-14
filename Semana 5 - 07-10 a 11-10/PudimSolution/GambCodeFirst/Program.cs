using CodeFirtTeste.Controller;
using CodeFirtTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GambCodeFirst
{
    class Program
    {
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            
            cerveja.AddCerveja(new Cerveja { Nome = "Cerveja Skol" });
            Console.ReadKey();

        }
    }
}
