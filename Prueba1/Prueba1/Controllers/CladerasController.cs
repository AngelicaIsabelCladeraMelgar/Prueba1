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
using Prueba1.Models;

namespace Prueba1.Controllers
{
    public class CladerasController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Claderas
        [Authorize]
        public IQueryable<Cladera> GetCladeras()
        {
            return db.Claderas;
        }

        // GET: api/Claderas/5
        [Authorize]
        [ResponseType(typeof(Cladera))]
        public IHttpActionResult GetCladera(int id)
        {
            Cladera cladera = db.Claderas.Find(id);
            if (cladera == null)
            {
                return NotFound();
            }

            return Ok(cladera);
        }

        // PUT: api/Claderas/5
        [Authorize]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCladera(int id, Cladera cladera)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cladera.CladeraID)
            {
                return BadRequest();
            }

            db.Entry(cladera).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CladeraExists(id))
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

        // POST: api/Claderas
        [Authorize]
        [ResponseType(typeof(Cladera))]
        public IHttpActionResult PostCladera(Cladera cladera)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Claderas.Add(cladera);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cladera.CladeraID }, cladera);
        }

        // DELETE: api/Claderas/5
        [Authorize]
        [ResponseType(typeof(Cladera))]
        public IHttpActionResult DeleteCladera(int id)
        {
            Cladera cladera = db.Claderas.Find(id);
            if (cladera == null)
            {
                return NotFound();
            }

            db.Claderas.Remove(cladera);
            db.SaveChanges();

            return Ok(cladera);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CladeraExists(int id)
        {
            return db.Claderas.Count(e => e.CladeraID == id) > 0;
        }
    }
}