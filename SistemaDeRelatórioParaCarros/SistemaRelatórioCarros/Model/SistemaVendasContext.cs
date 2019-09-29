using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRelatorioCarros.Model
{
    public class SistemaVendasContext//É necessário deixar ela pública
    {
        private List<Venda> ListaDeVendas { get; set; }//Vamos Criar nossa lista, o nome começa com MAIÚSCULO

        /// <summary>
        /// Contrutor que prepara nossa massa de dados
        /// </summary>
        public SistemaVendasContext()
        {
            ///Criamos nossa lista em memória, caso contrário ela fica null
            ListaDeVendas = new List<Venda>();

            //Abaixo nós colocamos os dados da lista
            ListaDeVendas.Add(new Venda() { Id = 1, Carro = "Risus Company", Valor = 7200, Quantidade = 18, Data = DateTime.Parse("29/01/2019")});
            ListaDeVendas.Add(new Venda() { Id = 2, Carro = "Risus Associates", Valor = 9961, Quantidade = 4, Data = DateTime.Parse("30/08/2019")});
            ListaDeVendas.Add(new Venda() { Id = 3, Carro = "Choros Associates", Valor = 8710, Quantidade = 62, Data = DateTime.Parse("21/03/2019") });
        }
        /// <summary>
        /// Lista que contém as vendas sem nenhum tipo de filtro
        /// </summary>
        public List<Venda> ListaVendasPublica { get { return ListaDeVendas; } }//Cria uma cópia da lista, onde não é possível modificar ela
    }
}
