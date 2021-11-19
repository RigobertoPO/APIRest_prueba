namespace APIPRUEBA.APIBIBLIO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Biblio.Libros")]
    public partial class Libro
    {
        public Guid Id { get; set; }

        [StringLength(10)]
        public string ISBN { get; set; }

        [Required]
        [StringLength(150)]
        public string Titulo { get; set; }

        public int? AñoPublicacion { get; set; }

        [StringLength(100)]
        public string Editorial { get; set; }
    }
}
