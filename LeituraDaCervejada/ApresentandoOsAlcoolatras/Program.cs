using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;


namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaController CervejaController = new CervejaController();
        public static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("Digite 1 para Adicionar Cerveja");
            Console.WriteLine("Digite 2 para Mostra a Lista");
            int n = int.Parse(Console.ReadLine());
            if (n == 1 )
            {
                AddCervejas();
                Menu();
            }
            if (n == 2)
            {
                MostrarLista();
                Menu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Você digitou uma opção inválida, tente novemante!!!\n");
                Menu();
            }
        }

        private static void AddCervejas()
        {
            Console.Clear();
            Console.WriteLine("Para Adicionar uma cerveja digite o que foi pedido\n");
            Console.Write("Informe o nome da cerveja: ");
            var nome = Console.ReadLine();
            Console.Write("Informe o volume em Litros: ");
            double litros = double.Parse(Console.ReadLine());
            Console.Write("Informe o teor de Álcool da cerveja: ");
            double alcool = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da cerveja: ");
            double valor = double.Parse(Console.ReadLine());

            //Como vou passar várias informações, eu crio um objeto do tipo cerveja que contém as caracterísicas 
            CervejaController.AdicionarCerveja(new Cerveja() { Nome = nome, Litros = litros, Alcool = alcool, Valor = valor });
            Console.WriteLine("\nCerveja Adiciona com Sucesso");
            Console.ReadKey();
        }
        private static void MostrarLista()
        {
            CervejaController.GetCervejas().ForEach(i => Console.WriteLine($"Nome: {i.Id} {i.Nome} {i.Litros} {i.Valor} {i.Alcool} "));
        }
    }
}
