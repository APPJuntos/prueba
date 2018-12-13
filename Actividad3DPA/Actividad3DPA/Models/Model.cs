namespace Actividad3DPA.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Modelo")
        {
        }

        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<users>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.nickname)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
