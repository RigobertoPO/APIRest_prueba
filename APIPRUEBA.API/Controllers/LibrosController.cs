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
using APIPRUEBA.API.Models;

namespace APIPRUEBA.API.Controllers
{
    public class LibrosController : ApiController
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        // GET: api/Libros
        public IQueryable<Libro> GetLibros()
        {
            return db.Libros;
        }

        // GET: api/Libros/5
        [ResponseType(typeof(Libro))]
        public IHttpActionResult GetLibro(Guid id)
        {
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            return Ok(libro);
        }

        // PUT: api/Libros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLibro(Guid id, Libro libro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != libro.Id)
            {
                return BadRequest();
            }

            db.Entry(libro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibroExists(id))
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

        // POST: api/Libros
        [ResponseType(typeof(Libro))]
        public IHttpActionResult PostLibro(Libro libro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Libros.Add(libro);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LibroExists(libro.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = libro.Id }, libro);
        }

        // DELETE: api/Libros/5
        [ResponseType(typeof(Libro))]
        public IHttpActionResult DeleteLibro(Guid id)
        {
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            db.Libros.Remove(libro);
            db.SaveChanges();

            return Ok(libro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LibroExists(Guid id)
        {
            return db.Libros.Count(e => e.Id == id) > 0;
        }
    }
}