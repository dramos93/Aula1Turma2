using BaseDadosVendas.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRelatorios

{
    class Program
    {
        static VendasController vendasController = new VendasController();//
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("Digite uma das opções Abaixo:\n ");
            Console.WriteLine("1 - Apresentar todos os dados: ");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    MostrarVendas();
                    Menu();
                    break;
                default:
                    break;
            }
        }
        public static void MostrarVendas()
        {
            var mostrar = vendasController.RetornaListaVendas();
            mostrar.ForEach(i => (i.QuantidadeVendas*i.ValorCarro));
            Console.ReadKey();
        }
        //mostrar.ForEach(i => Console.WriteLine($"Mês: {i.DataVendas.Month}"));
    }
}
