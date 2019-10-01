using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        #region programa inteiro
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Fruta>();
            #region Carregando Minha Cesta
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 325
            });
            #endregion
            #region Lista 1
            //Nesse ponto ordenamos os valores de forma decrescente pelo nome
            cestaDeFrutas.OrderByDescending(x => x.Nome).ToList<Fruta>().ForEach(i =>
            Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso: {i.Peso}"));
            Console.WriteLine("--------------------------------------------");
            #endregion
            #region Lista 2
            //Aqui ordenamos os valores pelo id de forma crescente
            cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().ForEach(i =>
            Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso: {i.Peso}"));
            Console.WriteLine("--------------------------------------------");
            #endregion
            #region Lista 3
            //Aqui filtramos os registros maiores de 100g e ordenamos por nome
            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x=>x.Nome);
            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso: {i.Peso}"));//Pego a variável e transformo em uma lista
            //Aqui nós fazemos uma seleção
             //frutinha recebe cada fruta de nossa cesta 
            (from frutinha in cestaDeFrutas //<- aqui temos a coleção de frutas
             where frutinha.Peso > 100 //<- aqui escolhemos somente frutas com mais de 100g
             select frutinha)//<- Neste ponto eu junto as informações que filtrei e retorno
                              .ToList<Fruta>()//<- Convertemos para uma lista amiga novamente 
                              .ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome}"));//<- imprimimos estas informações pelo console 
            #endregion
            #endregion
            #region Lista de Seleção por Cor
            Console.WriteLine("-------------------------------");

            //Aqui criamos uma variável que recebera o valor buscado
            var mostrandoFind = cestaDeFrutas.
                //Aqui é feito o filtro das informações por uma "ou --> || <--" outra cor
                Find(x => x.Cor == "Amarel" || x.Cor == "Vermelho");
            var mostrandoFindALL = cestaDeFrutas.
                //Find all com esta condição tras frutas de cor amarela "ou" vermelhas
                FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id: {mostrandoFind.Id} Nome: {mostrandoFind.Nome}");
            //Aqui criamos uma variável que receberá a coleção que estamos buscando
            mostrandoFindALL.ForEach(i => Console.WriteLine($"Id: {mostrandoFind.Id} Nome: {mostrandoFind.Nome}"));

            //Aqui ordenamos a lista pelo nome
            var listaOrdenada = mostrandoFindALL.OrderBy(x => x.Nome);
            //Como agora não é mais um List<Fruta> usamos o foreach para apresentar os valores
            foreach (var item in listaOrdenada)
                Console.WriteLine($"Id: {item.Id} Nome: {item.Nome}");

            Console.WriteLine("------------------------------- Find com order by");

            var cestaDeFrutasFindOrded = cestaDeFrutas
                //ordenei minha lista
                .OrderBy(x => x.Nome)
                //converti para lista de fruta novamente
                .ToList<Fruta>()
                //Busco minha informação
                .Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelhor");
            Console.WriteLine($"Id: {cestaDeFrutasFindOrded.Id} Nome: {cestaDeFrutasFindOrded.Nome}");



            Console.ReadKey();
            #endregion
        }
    }
}
