using ApiWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWebApi.Data
{
    public class ApiWebContext : DbContext
    {
        public ApiWebContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Studenti> Studenti { get; set; }
        public DbSet<Corsi> Corsi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Primary key esplicite
            modelBuilder.Entity<Studenti>().HasKey(s => s.IdStudente);
            modelBuilder.Entity<Corsi>().HasKey(c => c.IdCorso);

            // Relazione 1 Corso → N Studenti
            modelBuilder.Entity<Studenti>()
                .HasOne(s => s.Corso)
                .WithMany(c => c.Studenti)
                .HasForeignKey(s => s.IdCorso)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
