using APIPRUEBA.APIBIBLIOTECAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIPRUEBA.APIBIBLIOTECAS.Response
{
    public class LibrosResponse
    {
        public List<Libro> ListaLibros { get; set; }
        public Boolean Exito { get; set; }
        public string Mensaje { get; set; }
    }
}