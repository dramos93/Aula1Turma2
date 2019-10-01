using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization  ;


namespace dia07_01_ForeachNaLista
{
    class Program
    {
        /// <summary>
        /// Altera o valor prá Euro
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string   FormatToEuro(double meuNumero)
        {
            return (meuNumero * 0.22).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
        }
        /// <summary>
        /// Altera o valor prá Yen
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string   FormatToYen(double meuNumero)
        {
            return (meuNumero * 26.40).ToString("C", CultureInfo.CreateSpecificCulture("hi-IN"));//0,0042
        }
        /// <summary>
        /// Altera o valor prá bitCoin
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string   FormatToBitCoin(double meuNumero)
        {
            return (meuNumero * 0.000024).ToString("C6", CultureInfo.CreateSpecificCulture(""));
        }
        /// <summary>
        /// Altera o valor prá Dólar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormatToDolar(double meuNumero)//Entrando Double, retornando String
        {
            return (meuNumero * 0.24).ToString("C",CultureInfo.CreateSpecificCulture("en-US"));
        }
        /// <summary>
        /// List com Decimais
        /// </summary>
        private static void  ListaDecimais()
        {
            var minhaLista = new List<double>();
            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);

            minhaLista.ForEach(numeros => Console.WriteLine(numeros.ToString("C") + "Reais => " + FormatToDolar(numeros) + " Dólares => " + FormatToEuro(numeros) + " Euros => " + FormatToYen(numeros) + " Ienes => " + FormatToBitCoin(numeros)+" BitCoins"));//"C" transforma o valor em moeda.
        }
        private static  void    ListaNumeros()
        {
            var numerosListados = new List<int>();

            numerosListados.Add(17);
            numerosListados.Add(18);
            numerosListados.Add(19);
            numerosListados.Add(20);

            numerosListados.ForEach(i => Console.WriteLine(i));
        }
        /// <summary>
        /// List com data
        /// </summary>
        private static  void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 09, 17));
            minhaLista.Add(new DateTime(2019, 09, 18));
            minhaLista.Add(new DateTime(2019, 09, 19));
            minhaLista.Add(new DateTime(2019, 09, 20));

            minhaLista.ForEach(minhadata => Console.WriteLine(minhadata.ToString("yy/MMMM/dd")));
            //Para ser extenso tem que colocar .ToLongDateString();
        }

        /// <summary>
        /// List com String
        /// </summary>
        private static  void    ListaString()
        {
            var minhaLista = new List<string>();//o new aloca na memória, enquanto não for usada, não é alocada

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(i => Console.WriteLine(i));

            foreach (var item in minhaLista)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// List com Números
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            ListaDecimais();
            Console.ReadKey();

        }

    }
}
