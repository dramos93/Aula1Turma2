using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia06_Ex2_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            var listados = nomes.Split(';') ;

            foreach (var item in listados)
            {
                var nomeslistados = item.Split(',');
                var nome = nomeslistados[0].Split(':')[1];
                var idade = nomeslistados[1].Split(':')[1];
                if (int.Parse(idade) >= 18)
                {
                        Console.WriteLine($"{nome}");
                }
    
            }
            Console.ReadKey();
        }
    }
}
