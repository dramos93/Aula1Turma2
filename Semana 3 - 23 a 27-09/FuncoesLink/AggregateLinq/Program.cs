using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Felipe","Giomar","Euricledson","Adagoberto","Ezebio","Irineudson"
            };
            var texto = 
                //No Aggrate temos o nome atual que estamos lendo o próximo nome da lista
                listaDeNomes.Aggregate((nome1, nome2) => nome1 + ";" + nome2);
                //No passo seguinte temos o nome 'próximo' vira atual e pega o próximo da lista após o atual
            Console.WriteLine(texto);

        }
    }
}
