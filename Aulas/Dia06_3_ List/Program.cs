using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia06_3__List
{
    class Program
    {
        /// <summary>
        /// Método que tem a lista
        /// </summary>
        static  List<string> minhaListaPulgmatica = new List<string>()
            {
                "Felipe",
                "Irineu",
                "Serilop"
            };

        static void Main(string[] args)
        {
            AdicionarItensALista();

            ListaInformacoes();
            Console.ReadKey();
        }
        /// <summary>
        /// /Método que adiciona um item a Lista 
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome: ");
            var nome = Console.ReadLine();
            minhaListaPulgmatica.Add(nome);
            Console.Clear();
            Console.WriteLine($"Nome: {nome} foi adicionado a lista");
            Console.WriteLine("Deseja informar mais valores? Sim(S), Não(N) ");
            if (Console.ReadKey().KeyChar.ToString() == "S") //ToLower = transforma em minúsculo
                AdicionarItensALista();
            Console.Clear();
            Console.WriteLine("Nomes adicionados a lista com Sucesso");
            Console.ReadKey();
        }
        /// <summary>
        /// Método que tem mostra a lista
        /// </summary>
        private static  void   ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine("Nomes Adicionados a Lista");
            foreach(var item in minhaListaPulgmatica)
                Console.WriteLine($"Nome: {item} foi adicionado a lista");
        }
    }
}
