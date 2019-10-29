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
using CorreiosWebApi.Models;

namespace CorreiosWebApi.Controllers
{
    public class EnderecoesController : ApiController
    {
        private EnderecoContext db = new EnderecoContext();

        // GET: api/Enderecoes
        public IQueryable<Endereco> GetEnderecos()
        {
            return db.Enderecos;
        }

        [HttpGet]
        [Route("Api/Endereco/{cep}/Info")]
        public IQueryable<Endereco> EndereçoByCep(string cep)
        {
            return db.Enderecos.Where(x=> x.Cep == cep);
        }

        [HttpGet]
        [Route("Api/Enderecoes/{bairro}/InfoByBairro")]
        public IQueryable<Endereco> EndereçoByBairro(string bairro)
        {
            return db.Enderecos.Where(x => x.Bairro == bairro);
        }
        [HttpGet]
        [Route("Api/Enderecoes/{Logradouro}/InfoByLogradouro")]
        public IQueryable<Endereco> EndereçoByLogradouro(string logradouro)
        {
            return db.Enderecos.Where(x => x.Logradouro == logradouro);
        }

        [HttpGet]
        [Route("Api/Enderecoes/{Uf}/InfoByUf")]
        public IQueryable<Endereco> EndereçoByUf(string uf)
        {
            return db.Enderecos.Where(x => x.Uf == uf);
        }
        
        [HttpGet]
        [Route("Api/Enderecoes/{Municipio}/InfoByMunicipio")]
        public IQueryable<Endereco> EndereçoByMunicipio(string municipio)
        {
            return db.Enderecos.Where(x => x.Municipio == municipio);
        } 
        
        [HttpGet]
        [Route("Api/Enderecoes/{Complemento}/InfoByComplemento")]
        public IQueryable<Endereco> EndereçoByComplemento(string complemento)
        {
            return db.Enderecos.Where(x => x.Complemento == complemento);
        }

        

        // GET: api/Enderecoes/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult GetEndereco(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        // PUT: api/Enderecoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEndereco(int id, Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endereco.Id)
            {
                return BadRequest();
            }

            db.Entry(endereco).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Sucesso!");
        }

        // POST: api/Enderecoes
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult PostEndereco(Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Enderecos.Add(endereco);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = endereco.Id }, endereco);
        }

        // DELETE: api/Enderecoes/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult DeleteEndereco(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            db.Enderecos.Remove(endereco);
            db.SaveChanges();

            return Ok(endereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnderecoExists(int id)
        {
            return db.Enderecos.Count(e => e.Id == id) > 0;
        }
    }
}