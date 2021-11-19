using APIPRUEBA.APIBIBLIO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIPRUEBA.APIBIBLIO.Controllers
{
    public class LibrosController : ApiController
    {
        [Route("api/Libros/ObtenerLibros")]
        [HttpGet]
        public List<Libro> GetLibros()
        {
            using (var conexion = new BibliotecaModel())
            {
                var consulta = from c in conexion.Libros select c;

                return consulta.ToList();
            }
        }
        [Route("api/Libros/ObtenerLibrosOrdenadosNombre")]
        [HttpGet]
        public List<Libro> GetLibrosOrdenados()
        {
            using (var conexion = new BibliotecaModel())
            {
                var consulta = from c in conexion.Libros orderby c.Titulo select c ;

                return consulta.ToList();
            }
        }
        [Route("api/Libros/GuardarLibro")]
        [HttpPost]
        public bool PostLibro(Libro entidad)
        {
            try
            {
                using (var conexion = new BibliotecaModel())
                {
                    entidad.Id = Guid.NewGuid();
                    conexion.Libros.Add(entidad);
                    conexion.SaveChanges();
                    
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        [Route("api/Libros/ModificarLibro")]
        [HttpPut]
        public bool PutLibro(Libro entidad)
        {
            using (var conexion = new BibliotecaModel())
            {
                try
                {
                    var consulta = (from li in conexion.Libros
                                    where li.Id == entidad.Id
                                    select li).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.AñoPublicacion = entidad.AñoPublicacion;
                        consulta.Titulo = entidad.Titulo;
                        consulta.ISBN = entidad.ISBN;
                        consulta.Editorial = entidad.Editorial;
                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        [Route("api/Libros/EliminarLibro")]
        [HttpDelete]
        public bool DeleteLibro(Guid id)
        {
            using (var conexion = new BibliotecaModel())
            {
                try
                {
                    var consulta = (from li in conexion.Libros
                                    where li.Id == id
                                    select li).FirstOrDefault();
                    if (consulta != null)
                    {
                        conexion.Libros.Remove(consulta);
                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }
}
