using MinhaPrimeiraClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeBicicletas = new List<Bicicleta>
            {
                new Bicicleta()
                {
                    Marca = "Caloi"
                },
                new Bicicleta()
                {
                    Marca = "Monark"
                }
            };//Crio uma lista de Bicicletas
            listaDeBicicletas.ForEach(i => Console.WriteLine($"Bikeon > Marca: {i.Marca} Pneus: {i.Pneus}"));
            Console.ReadKey();
        }
    }
}
