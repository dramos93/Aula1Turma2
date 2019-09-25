using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vendas> vendas = new List<Vendas>()
            {
                new Vendas()
                {
                    Produto = "XIAOMI Lite 6 quad Core 128gb 32px frontal",
                    Quantidade = 8,
                    Valor = 1200.75
                },
                new Vendas()
                {
                    Produto = "SLIM 3500 APP",
                    Quantidade = 5,
                    Valor = 2800.96
                },
                new Vendas()
                {
                    Produto = "IPHONE FOGÃO 3 BOCAS",
                    Quantidade = 1,
                    Valor = 9999.99
                },
            };
            Console.Write("A Média de Produtos é:  ");
            Console.WriteLine(vendas.Average(i => i.Quantidade));
            Console.Write("A Média de vendas em Reais é:  ");
            Console.WriteLine(vendas.Average(i => (i.Quantidade * i.Valor)));//Aqui temos a média de vendas * a média de quantidade no mês
        }
    }
}
