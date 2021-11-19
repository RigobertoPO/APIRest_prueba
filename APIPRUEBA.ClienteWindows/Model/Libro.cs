using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPRUEBA.ClienteWindows.Model
{
     public class Libro
    {
        public Guid Id { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int? AñoPublicacion { get; set; }
        public string Editorial { get; set; }
    }
}
