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
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LeerlingsController : ApiController
    {
        private WebApplication1Context db = new WebApplication1Context();

        // GET: api/Leerlings
        public IQueryable<Leerling> GetLeerlings()
        {
            return db.Leerlings;
        }

        // GET: api/Leerlings/5
        [ResponseType(typeof(Leerling))]
        public IHttpActionResult GetLeerling(string id)
        {
            Leerling leerling = db.Leerlings.Find(id);
            if (leerling == null)
            {
                return NotFound();
            }

            return Ok(leerling);
        }

        // PUT: api/Leerlings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLeerling(string id, Leerling leerling)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != leerling.Id)
            {
                return BadRequest();
            }

            db.Entry(leerling).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeerlingExists(id))
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

        // POST: api/Leerlings
        [ResponseType(typeof(Leerling))]
        public IHttpActionResult PostLeerling(Leerling leerling)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Leerlings.Add(leerling);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LeerlingExists(leerling.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = leerling.Id }, leerling);
        }

        // DELETE: api/Leerlings/5
        [ResponseType(typeof(Leerling))]
        public IHttpActionResult DeleteLeerling(string id)
        {
            Leerling leerling = db.Leerlings.Find(id);
            if (leerling == null)
            {
                return NotFound();
            }

            db.Leerlings.Remove(leerling);
            db.SaveChanges();

            return Ok(leerling);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LeerlingExists(string id)
        {
            return db.Leerlings.Count(e => e.Id == id) > 0;
        }
    }
}