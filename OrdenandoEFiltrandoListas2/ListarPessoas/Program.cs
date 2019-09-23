using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDePessoas = new List<Pessoas> ();
            listaDePessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Spears",
                DatadeNascimento = DateTime.Parse("07/11/2004"),
                carteira = 846.96
            }); listaDePessoas.Add(new Pessoas()
            {
                Id = 2,
                Nome = "Swanson",
                DatadeNascimento = DateTime.Parse("20/06/2003"),
                carteira = 233.09
            }); listaDePessoas.Add(new Pessoas()
            {
                Id = 3,
                Nome = "Gay",
                DatadeNascimento = DateTime.Parse("03/12/2001"),
                carteira = 911.92
            }); listaDePessoas.Add(new Pessoas()
            {
                Id = 4,
                Nome = "Gregory",
                DatadeNascimento = DateTime.Parse("02/01/2000"),
                carteira = 469.01
            });
            Console.WriteLine("--------------------------Ordem Alfabética----------------------------");
            //Aqui ele ordena por ordem Alfabética
            listaDePessoas.OrderBy(x => x.Nome).ToList<Pessoas>().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Data de Nascimento: {i.DatadeNascimento.ToString("dd/MM/yyyy")} Salário: {i.carteira}"));

            Console.WriteLine("-----------------Ordem do mais novo pro mais velho--------------------");
            //Aqui ele ordena por Ordem do mais novo pro mais velho
            listaDePessoas.OrderByDescending(x => x.DatadeNascimento).ToList<Pessoas>().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Data de Nascimento: {i.DatadeNascimento.ToString("dd/MM/yyyy")} Salário: {i.carteira}"));

            Console.WriteLine("-----------------------Carteira Maior que 500-------------------------");
            //Aqui ele filtra para carteira maior que 500
            (from salario in listaDePessoas where salario.carteira > 500 select salario).ToList<Pessoas>().ForEach(i => Console.WriteLine($"Nome: {i.Nome} Salário: R$ {i.carteira}"));

            Console.WriteLine("-------------------------Maiores de 18 anos---------------------------");
            //Aqui mostra quem são os maiores de 18 anos
            (from maiores in listaDePessoas where maiores.DatadeNascimento < DateTime.Now.AddYears(-18) select maiores).ToList<Pessoas>().ForEach(i => Console.WriteLine($"Nome: {i.Nome} Data de Nascimento: R$ {i.DatadeNascimento.ToString("dd/MM/yyyy")}"));

            Console.WriteLine("--------------------------Menores de 16 anos--------------------------");
            //Aqui mostra quem são os menores de 16 anos-
            var filtromenores = listaDePessoas.Where(x => x.DatadeNascimento > (DateTime.Now.AddYears(-16))).OrderBy(x => x.Nome);

            filtromenores.ToList<Pessoas>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome {i.Nome} Idade {i.DatadeNascimento.ToString("dd/MM/yyyy")}"));
            
        }
    }
}
