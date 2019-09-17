using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia07_02_MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChamarMain();//Vai para o Método Principal;
        }
        /// <summary>
        /// Aqui é a programação principal
        /// </summary>
        public static void ChamarMain()
        {
            Console.WriteLine("---Sistema Conversos de moedas cabuloso---");
            Console.WriteLine("Informe um valor a ser convertido: ");

            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão: ");
            Console.WriteLine("DOLAR,EURO,YEN,BTC");

            var moedaAlvoParaConverter = Console.ReadLine().ToUpper();

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);

            Console.ReadKey();
        }
        /// <summary>
        /// Método que Converte moeda de real para um alvo específico:
        /// Euro
        /// ien
        /// Dolar
        /// BTC
        /// </summary>
        /// <param name="minhaMoeda"></param>
        /// <param name="moedaAlvo"></param>
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {
            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormatToDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormatToEuro(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormatToYen(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormatToBitCoin(minhaMoeda));
                    break;
                default :
                    break;
            }
        }
         private static string FormatToDolar(double meuNumero)//Entrando Double, retornando String
        {
            return (meuNumero * 0.24).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
        /// <summary>
        /// Altera o valor prá Euro
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormatToEuro(double meuNumero)
        {
            return (meuNumero * 0.22).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
        }
        /// <summary>
        /// Altera o valor prá Yen
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormatToYen(double meuNumero)
        {
            return (meuNumero * 26.40).ToString("C", CultureInfo.CreateSpecificCulture("hi-IN"));//0,0042
        }
        /// <summary>
        /// Altera o valor prá bitCoin
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormatToBitCoin(double meuNumero)
        {
            return (meuNumero * 0.000024).ToString("C6", CultureInfo.CreateSpecificCulture(""));
        }
    }
}
