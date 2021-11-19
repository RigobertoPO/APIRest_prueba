using APIPRUEBA.APIBIBLIOTECAS.Models;
using APIPRUEBA.APIBIBLIOTECAS.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIPRUEBA.APIBIBLIOTECAS.Controllers
{
    public class LibrosController : ApiController
    {
        //[HttpGet]
        //public LibrosResponse GetLibros()
        //{
        //    try
        //    {
        //        using (var conexion = new BibliotecaModel())
        //        {
        //            var consulta = from c in conexion.Libros select c;
        //            LibrosResponse response = new LibrosResponse();
        //            response.ListaLibros = consulta.ToList();
        //            response.Exito = true;
        //            response.Mensaje = "Consulta correcta";
        //            return response;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        LibrosResponse response = new LibrosResponse();
        //        response.Exito = false;
        //        response.Mensaje = e.Message;
        //        return response;
        //    }
             
        //}
        [HttpGet]
        public List<Libro> GetLibros()
        {
            using (var conexion = new BibliotecaModel())
            {
                var consulta = from c in conexion.Libros select c;
               
                return consulta.ToList();
            }
        }
        [HttpGet]
        public Libro GetLibro(string nombre)
        {
            using (var conexion = new BibliotecaModel())
            {
                var consulta = (from c in conexion.Libros where c.Titulo==nombre select c).FirstOrDefault();

                return consulta;
            }
        }
        //[HttpPost]
        //public Boolean PostLibro(Libro entidad)
        //{
        //    using(var conexion =new BibliotecaModel())
        //    {
        //        entidad.Id = Guid.NewGuid();
        //        conexion.Libros.Add(entidad);
        //        conexion.SaveChanges();
        //        return true;
        //    }
        //}
        [HttpPost]
        public LibrosResponse PostLibro(Libro entidad)
        {
            try
            {
                using (var conexion = new BibliotecaModel())
                {
                    entidad.Id = Guid.NewGuid();
                    conexion.Libros.Add(entidad);
                    conexion.SaveChanges();
                    LibrosResponse response = new LibrosResponse();
                    response.Exito = true;
                    response.Mensaje = "El libro se guardo correctamente";
                    return response;
                }
            }
            catch (Exception e)
            {
                LibrosResponse response = new LibrosResponse();
                response.Exito = false;
                response.Mensaje = e.Message;
                return response;
            }
        }
        [HttpPut]
        public bool PutLibro(Libro entidad)
        {
            using(var conexion=new BibliotecaModel())
            {
                try
                {
                    var consulta = (from li in conexion.Libros
                                    where li.Id == entidad.Id
                                    select li).FirstOrDefault();
                    if(consulta!=null)
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
