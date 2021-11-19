using APIPRUEBA.APIBIBLIOTECAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIPRUEBA.APIBIBLIOTECAS.Controllers
{
    public class UsuariosController : ApiController
    {
        [Route("api/Usuarios/ObtenerTodosUsuarios")]
        [HttpGet]
        public List<Usuario> GetUsuarios()
        {
            using (var conexion = new BibliotecaModel())
            {
                var consulta = from c in conexion.Usuarios select c;

                return consulta.ToList();
            }
        }
    }
}
