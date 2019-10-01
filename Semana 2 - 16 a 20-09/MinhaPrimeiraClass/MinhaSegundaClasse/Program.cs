using MinhaSegundaClasse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MinhaSegundaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeFrutas = new List<CestaDeFrutas>();
            listaDeFrutas.Add(new CestaDeFrutas()
            {
                Nome = "banana",Quantidade =5
            });
            listaDeFrutas.ForEach(i => Console.WriteLine($"Nome {i.Nome} Quantidade {i.Quantidade}"));
            Console.ReadKey();
        }
    }
}
