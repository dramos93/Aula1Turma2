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
using RegistroImoveis.Models;

namespace RegistroImoveis.Controllers
{
    public class ProprietariosController : ApiController
    {
        private MigrationsContext db = new MigrationsContext();

        // GET: api/Proprietarios
        public IQueryable<Proprietarios> GetProprietarios()
        {
            return db.Proprietarios;
        }

        // GET: api/Proprietarios/5
        [ResponseType(typeof(Proprietarios))]
        public IHttpActionResult GetProprietarios(string id)
        {
            Proprietarios proprietarios = db.Proprietarios.Find(id);
            if (proprietarios == null)
            {
                return NotFound();
            }

            return Ok(proprietarios);
        }

        // PUT: api/Proprietarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProprietarios(string id, Proprietarios proprietarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proprietarios.Nome)
            {
                return BadRequest();
            }

            db.Entry(proprietarios).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProprietariosExists(id))
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

        // POST: api/Proprietarios
        [ResponseType(typeof(Proprietarios))]
        public IHttpActionResult PostProprietarios(Proprietarios proprietarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Proprietarios.Add(proprietarios);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProprietariosExists(proprietarios.Nome))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = proprietarios.Nome }, proprietarios);
        }

        // DELETE: api/Proprietarios/5
        [ResponseType(typeof(Proprietarios))]
        public IHttpActionResult DeleteProprietarios(string id)
        {
            Proprietarios proprietarios = db.Proprietarios.Find(id);
            if (proprietarios == null)
            {
                return NotFound();
            }

            db.Proprietarios.Remove(proprietarios);
            db.SaveChanges();

            return Ok(proprietarios);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProprietariosExists(string id)
        {
            return db.Proprietarios.Count(e => e.Nome == id) > 0;
        }
    }
}