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
        [Route("Api/Carroes/CarrosComMarcas")]
        public object CustomCarrosOnMarcas()
        {
            var listaCarros = db.Carros.ToList();
            var listaMarcas = db.Marcas.ToList();
            var conteudoRetorno = from mar in listaMarcas
                                  join car in listaCarros on mar.Id
                                  equals car.Marca
                                  select new { CarroId = car.Id, CarroNome = car.Modelo, MarcaId = mar.Id, MarcaNome = mar.Nome };

            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/Carroes/CarrosComUsuarios")]
        public object CarrosComUsuarios()
        {
            var listaCarros = db.Carros.ToList();
            var listaUsuarios = db.Usuarios.ToList();



            var conteudoRetorno = from Usu in listaUsuarios
                                  join car in listaCarros on Usu.Id
                                  equals car.Marca
                                  select new { CarroId = car.Id, CarroNome = car.Modelo, IdUsuario = Usu.Id, NomeUsuario = Usu.Usuario };

            return conteudoRetorno;
        }


    }
}