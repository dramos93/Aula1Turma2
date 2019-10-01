using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;
using ListagemDeCervejas.Controller;


namespace cervejaTemplate
{
    class Program
    {
        static CervejaControler cervejaControler = new CervejaControler();

        /// <summary>
        /// Parte Principal do Programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MostrarMenu();
        }

        /// <summary>
        /// Mostra as opções Disponíveis
        /// </summary>
        private static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\tCERVEJAS AMBEV");
            Console.WriteLine("\n*****************************");
            Console.WriteLine("\n\tMENU");
            Console.WriteLine("\n1 - Mostrar Lista");
            Console.WriteLine("2 - Adicionar Cerveja");
            Console.WriteLine("3 - Retornar Valor Total da Lista");
            Console.WriteLine("4 - Retornar Volume de cerveja da Lista");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("\n*****************************");
            Console.Write("\nDigite uma das opções do Menu: ");

            // 
            switch (Console.ReadLine())
            {
                case "0": break;
                case "1":
                    MostrarCervejas();
                    MostrarMenu();
                    break;
                case "2":
                    AddCervejas();
                    MostrarMenu();
                    break;
                case "3":
                    ValorTotal();
                    MostrarMenu();
                    break;
                case "4":
                    VolumeTotal();
                    MostrarMenu();
                    break;
                default:
                    break;
            }
        }

        private static void ValorTotal()
        {
            Console.Clear();

            Console.WriteLine($"O Valor Total que temos de cerveja é de: {cervejaControler.ValorTotalCerveja()}");
            Console.ReadKey();
        }
        private static void VolumeTotal()
        {
            Console.Clear();
            
            Console.WriteLine($"O Volume Total que temos de cerveja é de: {cervejaControler.VolumeCerveja()} Litros");
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
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
            cervejaControler.AdicionarCerveja( new Cerveja(){Nome = nome, Litros=litros,Alcool=alcool,Valor=valor});
        }

        private static void MostrarCervejas()
        {
            Console.Clear();
            Console.WriteLine("*****************LISTA DE CERVEJAS***************");
            cervejaControler.ListagemDeCervejas().
                ForEach(i => Console.WriteLine(string.Format("ID: {0,-2} Nome: {1,-20} Volume: {2,-5} Litros Valor: {3,8}",i.Id,i.Nome, i.Litros.ToString("0.000"), i.Valor.ToString("C2"))));
            Console.ReadKey();
        }
    }
}
