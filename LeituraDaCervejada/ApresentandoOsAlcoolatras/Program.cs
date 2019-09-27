using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;

namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaController CervejaController = new CervejaController();
        public static void Main(string[] args)
        {
            CervejaController.GetCervejas().ForEach(i => Console.WriteLine($"Nome: {i.Id} {i.Nome} {i.Litros} {i.Valor} {i.Alcool} "));
        }
    }
}
