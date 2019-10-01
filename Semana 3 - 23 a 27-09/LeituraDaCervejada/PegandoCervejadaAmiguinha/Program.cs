using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;


namespace PegandoCervejadaAmiguinha
{
    public class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
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
            cervejaControler.AdicionarCerveja(new Cerveja() { Nome = nome, Litros = litros, Alcool = alcool, Valor = valor });
        }
    }
}
