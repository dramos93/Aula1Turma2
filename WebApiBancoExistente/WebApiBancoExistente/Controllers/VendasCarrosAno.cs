using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class CarrosController
    {
        [HttpGet]
        [Route("Api/Vendas/Ano")]
        public object VendasAno(int ano)
        {
            var listaVendas = db.Vendas.ToList();
            var listaCarros = db.Carros.ToList();
            var listaUsuarios = db.Usuarios.ToList();
            var listaMarcas = db.Marcas.ToList();

            //var retornoCarros = from Vendas in listaVendas select  new { Carro = Vendas.Carro, Valor = Vendas.Valor, Data = Vendas.DatInc };

            var retornoCarros =  from ven in listaVendas
                                join usu in listaUsuarios
                                on ven.UsuInc equals usu.Id
                                join car in listaCarros
                                on ven.Carro equals car.Id
                                join mar in listaMarcas
                                on car.Marca equals mar.Id
                                where ven.DatInc.Year == ano
                                select new { Carro = car.Modelo, Marca= mar.Nome ,Quantidade = ven.Quantidade, Valor = ven.Valor, DatInc = ven.DatInc, Usuario = usu.Usuario};
            return retornoCarros;
        }
        [HttpGet]
        [Route("Api/Vendas/MarcasVendida")]
        public object MarcasVendida(int ano)
        {
            var listaVendas = db.Vendas.ToList();
            var listaCarros = db.Carros.ToList();
            var listaMarcas = db.Marcas.ToList();

            var retornoCarros = from ven in listaVendas
                                join car in listaCarros on ven.Carro equals car.Id
                                join mar in listaMarcas on car.Marca equals mar.Id
                                where ven.DatInc.Year == ano
                                group ven by ven.Carros.Marcas into GroupBy
                                select new 
                                {    
                                    Marcas = GroupBy.Key.Nome,
                                    Quantidade = GroupBy.Sum(x => x.Quantidade)
                                };
            return retornoCarros;

        }
    }
}