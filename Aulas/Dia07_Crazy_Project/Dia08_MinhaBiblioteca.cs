using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dia07_Crazy_Project
{
    public class Dia07_MinhaBiblioteca
    {
        /// <summary>
        /// Método que chama os Métodos: Árvore, CalculoArea, ListaCervejas, ListaCarro
        /// </summary>
        public static void IniciarPrograma()
        {

            MetodoArvore();
            MetodoCalculoArea();
            MetodoListaCerveja();
            MetodoListaCarro();
        }
        /// <summary>
        /// Método que mostra árvore
        /// </summary>
        public static void MetodoArvore()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine("    **   ");
                Console.WriteLine("   ****   ");
                Console.WriteLine("  ******   ");
                Console.WriteLine(" ******** ");
                Console.WriteLine("    **   ");
                Console.WriteLine("    **   ");
                Thread.Sleep(350);
                Console.Clear();
                Console.WriteLine("     **   ");
                Console.WriteLine("    ****   ");
                Console.WriteLine("  ******   ");
                Console.WriteLine(" ******** ");
                Console.WriteLine("    **   ");
                Console.WriteLine("    **   ");
                Thread.Sleep(350);
            }
        }
        /// <summary>
        /// Método que calcula área de um quadrado
        /// </summary>
        public static void MetodoCalculoArea()
        {
            Console.WriteLine("--- Cálculo de Área de um Quadrado ---");
            Console.WriteLine("Digite o valor de um do lado: ");
            int lado = int.Parse(Console.ReadLine());
            lado = lado * lado;
            Console.WriteLine($"\nO valor da área do quadrado é de : {lado} metros");
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra uma Lista de Cervejas da AMBEV
        /// </summary>
        public static void MetodoListaCerveja()
        {
            var cervejas = new List<string>()
            { "Brahma", "Skol", "Antartica", "Patagonia", "Original"};
            cervejas.ForEach(nomes => Console.WriteLine(nomes));
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Morta uma Lista de Marcas de Carro
        /// </summary>
        public static void MetodoListaCarro()
        {
            var carros = new List<string>()
            { "BMW", "Fiat", "Ford", "Chevrolet", "Kia", "volkswagen", "Mercedes-Benz"};
            carros.ForEach(nomes => Console.WriteLine(nomes));
            Console.ReadKey();
            Console.Clear();
        }
    }
}
