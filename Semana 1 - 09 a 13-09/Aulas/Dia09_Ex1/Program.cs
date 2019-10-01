using Dia09_Ex1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia09_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui é criado uma lista chamada lista de lista amizade, 
            //new porque foi alocado na memória, Lista é a lista e dentro dela é colocada a classe
            var listaAmizade = new List<Amigos>();
            //Abaixo colocamos um for para passar várias vezes o nome e o tempo de amizade
            for (int i = 0; i < 5; i++)
            {
                {
                    //Aqui é a mensagem pro usuáro colocar o que foi solicitado
                    Console.WriteLine("Digite nome de um amigo: ");
                    var nomeDescrito = Console.ReadLine();
                    Console.WriteLine("Digite o tempo de amizade do amigo: ");
                    var tempoDescrito = Console.ReadLine();
                    //Aqui é dado um add, ou seja adicionado para a lista listaAmizade, depois criado um espaço
                    // na memória com o new, esse espaço é para dentro da class amigos
                    listaAmizade.Add(new Amigos()
                    {
                        Nome = nomeDescrito,// dentro da classe Amigos vai ficar salvo dentro do nome
                        TempoDeAmizade = int.Parse(tempoDescrito)
                    });;
                }
                Console.Clear();

            }
            listaAmizade.ForEach(j => Console.WriteLine($"Nome: {j.Nome}, Tempo de Amizade: {j.TempoDeAmizade}"));
            
        }
    }
}
