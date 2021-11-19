namespace APIPRUEBA.APIBIBLIOTECAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Biblio.Prestamos")]
    public partial class Prestamo
    {
        public Guid Id { get; set; }

        public Guid IdLibro { get; set; }

        public Guid IdUsuario { get; set; }

        public DateTime? FechaPrestamo { get; set; }

        public bool Activo { get; set; }
    }
}
