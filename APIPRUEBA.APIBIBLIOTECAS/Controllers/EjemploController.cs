using APIPRUEBA.APIBIBLIOTECAS.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
namespace APIPRUEBA.APIBIBLIOTECAS.Controllers
{
    public class EjemploController : ApiController
    {
        public List<Escuela> listaEscuelas = new List<Escuela>();
        public EjemploController()
        {
            Escuela e1 = new Escuela { Id = 1, Nombre = "Angel albino corzo", Nivel = "Primaria" };
            listaEscuelas.Add(e1);
            Escuela e2 = new Escuela { Id = 2, Nombre = "UNACH", Nivel = "Universidad" };
            listaEscuelas.Add(e2);
            Escuela e3 = new Escuela { Id = 3, Nombre = "Camilo Pintado", Nivel = "Primaria" };
            listaEscuelas.Add(e3);
        }
        [HttpGet]
        public string saludar(string nombre)
        {
            return nombre + " Bienvenido a API Rest";
        }
        [HttpGet]
        public List<Escuela> GetEscuelas()
        {
            var consulta=( from l in listaEscuelas where l.Nivel == "Primaria" select l);
            return consulta.ToList();
        }
    }
}
