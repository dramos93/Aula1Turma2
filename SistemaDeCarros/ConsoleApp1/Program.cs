using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;
using ListagemDeCarros.Model;



namespace ConsoleApp1
{
    class Program
    {
        static CarroController carroController = new CarroController();
        static void Main(string[] args)
        {
            Console.WriteLine();
            carroController.Listar().ForEach(i => Console.WriteLine($"{i.Marca} {i.Modelo} - {i.Ano}"));
            Console.ReadKey();
        }
    }
}
