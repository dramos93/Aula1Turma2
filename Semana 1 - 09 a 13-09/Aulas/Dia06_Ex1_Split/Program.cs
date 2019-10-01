using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia06_Ex1_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            ListadeCarros();
            Console.ReadKey();
        }
        /// <summary>
        /// Método que mostra como podemos utilizae o foreach para andar sobre
        /// uma array de caracteres, ou seja, um texto ou palabra, etc..
        /// </summary>
        private static void InciandoForeach01()

        {
            Console.WriteLine("Informar o texto: ");
            var conteudoTexto = Console.ReadLine();
            foreach (var item in conteudoTexto) //
            {
                if (item == 'e')
                    continue;//Aqui ele pula o que está abaixo dele.
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Método de busca com split e informando o nome
        /// </summary>
        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe seu nome: ");
            var conteudoTexto = $@"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";
            Console.WriteLine("Informe a palavra para realizar a busca> ");
            var palavra = Console.ReadLine();
            var conteudoTextoSplit = conteudoTexto.Split(';');// Quebra a informação por algo.
            foreach (var item in conteudoTextoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }
            Console.ReadKey();
        }
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Felipe,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";

            var listaDeInformãcoes = conteudo.Split(';');

            Console.WriteLine("Usuários cadastrados: ");

            foreach (var item in listaDeInformãcoes)
            {
                Console.WriteLine(item.Split(',')[0]);// O que está entre parênteses mostra a coluna que está meu texto principal
            }
            Console.WriteLine("Informe um nome do sistema: ");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformãcoes)
            {
                var informacaoSplit = item.Split(',');
                var nome = informacaoSplit[0].Split(':')[1];
                var idade = informacaoSplit[1].Split(':')[1];
                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de vida.");

                }
            }

        }
        private static void ListadeCarros()
        {
            var texto = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            var lista = texto.Split(';'); //Aqui ele divide até na ;
            Console.WriteLine("Informe o nome do carro: ");
            var carroBusca = Console.ReadLine();
            foreach (var item in lista)
            {
                var informacaoSplit = item.Split(','); //Aqui ele pega as subdivisão e divide até a ,
                var carro = informacaoSplit[0].Split(':')[1];// Aqui ele pega a primeira info e divide em dois e paga a 2ª informação[1]
                var marca = informacaoSplit[1].Split(':')[1];// Aqui ele pega a segunda info e divide em dois e paga a 2ª informação[1]
                var ano = informacaoSplit[2].Split(':')[1];// Aqui ele pega a teerceira info e divide em dois e paga a 2ª informação[1]

                if (carro == carroBusca)
                {
                    Console.WriteLine($"O {carro} é da marca {marca}  e o ano é {ano}.");

                }
            }

        }


    }
}
