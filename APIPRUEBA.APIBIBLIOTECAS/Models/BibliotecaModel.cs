using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace APIPRUEBA.APIBIBLIOTECAS.Models
{
    public partial class BibliotecaModel : DbContext
    {
        public BibliotecaModel()
            : base("name=BibliotecaEntities")
        {
        }

        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Prestamo> Prestamos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>()
                .Property(e => e.ISBN)
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.Editorial)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.NivelEstudio)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Telefono)
                .IsUnicode(false);
        }
    }
}
