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
    }
}