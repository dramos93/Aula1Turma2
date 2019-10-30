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
    public class CarrosController : ApiController
    {
        private Carroes db = new Carroes();

        [HttpGet]
        [Route("Api/Carroes/CustomQueryCarros")]
        public object CustomQueryCarros()
        {
            var listaDeCarros = db.Carros.ToList();

            var retornoCarros = from carros in listaDeCarros 
                                select new {NomeCarro = carros.Modelo, CarrosId = carros.Id };

            return retornoCarros;
        }

        [HttpGet]
        [Route("Api/Carroes/CustomQueryMarcas")]
        public object CustomQueryMarcas()
        {
            var listaDeMarcas = db.Marcas.ToList();

            var retornoCarros = from Marcas in listaDeMarcas 
                                select new { NomeMarca = Marcas.Nome, MarcasId = Marcas.Id };

            return retornoCarros;
        }

        [HttpGet]
        [Route("Api/Carroes/CustomQueryUsuarios")]
        public object CustomQueryUsuarios()
        {
            var listaDeUsuarios = db.Usuarios.ToList();

            var retornoCarros = from Usuarios in listaDeUsuarios 
                                select new { NomeUsuario = Usuarios.Usuario, UsuaruiosId = Usuarios.Id };

            return retornoCarros;
        }

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
                                  select new { CarroId = car.Id, CarroNome = car.Modelo, IdUsuario = Usu.Id, NomeUsuario= Usu.Usuario };

            return conteudoRetorno;
        }














        // GET: api/Carros
        public IQueryable<Carros> GetCarros()
        {
            return db.Carros;
        }

        // GET: api/Carros/5
        [ResponseType(typeof(Carros))]
        public IHttpActionResult GetCarros(int id)
        {
            Carros carros = db.Carros.Find(id);
            if (carros == null)
            {
                return NotFound();
            }

            return Ok(carros);
        }

        // PUT: api/Carros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarros(int id, Carros carros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carros.Id)
            {
                return BadRequest();
            }

            db.Entry(carros).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Carros
        [ResponseType(typeof(Carros))]
        public IHttpActionResult PostCarros(Carros carros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carros.Add(carros);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carros.Id }, carros);
        }

        // DELETE: api/Carros/5
        [ResponseType(typeof(Carros))]
        public IHttpActionResult DeleteCarros(int id)
        {
            Carros carros = db.Carros.Find(id);
            if (carros == null)
            {
                return NotFound();
            }

            db.Carros.Remove(carros);
            db.SaveChanges();

            return Ok(carros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarrosExists(int id)
        {
            return db.Carros.Count(e => e.Id == id) > 0;
        }
    }
}