﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIPRUEBA.API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PruebaEntities : DbContext
    {
        public PruebaEntities()
            : base("name=PruebaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<ObtenerLibros_Result> ObtenerLibros()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerLibros_Result>("ObtenerLibros");
        }
    }
}
