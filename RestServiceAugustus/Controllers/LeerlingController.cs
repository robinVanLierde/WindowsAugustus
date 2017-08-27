using RestServiceAugustus.DbContext;
using RestServiceAugustus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace RestServiceAugustus.Controllers
{
    public class LeerlingController : ApiController
    {

        private RestServiceDbContext db = new RestServiceDbContext();
        // GET: api/Leerling
        public IQueryable<Leerling> Getleerlingen()
        {
            //Leerling leerling1 = new Leerling()
            //{ Naam = "robin",
            //    opleiding = "test",
            //    Voornaam = "robin",
            //    campus = "test",
            //    Email = "test",
            //    Telefoon="test",
            //    Id="test"

            //};
            //db.Leerling.Add(leerling1);
            //db.SaveChanges();

            return db.Leerling;
        }

        // GET: api/Leerling/5
        [ResponseType(typeof(Leerling))]
        public IHttpActionResult GetLeerling(int id)
        {
            Leerling leerling = db.Leerling.Find(id);
            if (leerling == null)
            {
                return NotFound();
            }
            return Ok(leerling);
        }

        // POST: api/Leerling
        [ResponseType(typeof(Leerling))]
        public IHttpActionResult PostLeerling(Leerling leerling)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Leerling.Add(leerling);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = leerling.Id }, leerling);

        }

        // PUT: api/Leerling/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Leerling/5
        [ResponseType(typeof(Leerling))]
        public IHttpActionResult DeleteLeerling(int id)
        {
            Leerling leerling = db.Leerling.Find(id);
            if (leerling ==null)
            {
                return NotFound();
            }
            db.Leerling.Remove(leerling);
            db.SaveChanges();

            return Ok(leerling);
        }
    }
}
