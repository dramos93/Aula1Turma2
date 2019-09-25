using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLink
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteirosPrimitivos();
            SomaInteirsLista();
            SomaBalasListaDeCriancas();

            Console.ReadKey();
        }
        /// <summary>
        /// Métodos que mostra números inteiros de uma coleção Primitiva
        /// </summary>
        private static void SomarInteirosPrimitivos()
        {
            //quando utiliamos "[]" em um tipo primitivo podemos criar uma coleção destes
            // valores
            //[n] - Quantidade de memória que será ocupada
            int[] colecaoInteiros = new int[5] { 1, 2, 3, 4, 5 };// "{}" aqui carregamos nossa coleção de valores
            //Dessa maneira fica mais leve que fazer uma lista

            Console.WriteLine(colecaoInteiros.Sum());
        }
        /// <summary>
        /// Método que mostra a soma de números inteiros de uma lista
        /// </summary>
        private static void SomaInteirsLista()
        {
            // Na lista eu consigo acrescentar mais valores..
            List<int> listaDeInteiros = new List<int>()
            {
                1,2,3,4,5
            };

            Console.WriteLine(listaDeInteiros.Sum());
        }
        /// <summary>
        /// Método que soma a quantidade de balas das crianças
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            //Nossa lista de crianças foi criada e carregada em memória
            List<Crianca> criancas = new List<Crianca>()
            {
                //criando uma crianla dentri da minha Lista
                new Crianca()
                {
                    Nome = "Joãzinho",
                    Balas = 9
                },
                new Crianca()
                {
                    Nome = "Pedrinho",
                    Balas = 68
                }
            };
            //Soma a quantidade de balas
            Console.Write("Quantidade total de balas que as crianças levaram da venda: ");
            Console.WriteLine(criancas.Sum(x=> x.Balas));


        }
    }
}
