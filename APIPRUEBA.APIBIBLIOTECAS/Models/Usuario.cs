namespace APIPRUEBA.APIBIBLIOTECAS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Biblio.Usuarios")]
    public partial class Usuario
    {
        public Guid Id { get; set; }

        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(25)]
        public string NivelEstudio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        [StringLength(18)]
        public string CURP { get; set; }

        [StringLength(13)]
        public string Telefono { get; set; }
    }
}
