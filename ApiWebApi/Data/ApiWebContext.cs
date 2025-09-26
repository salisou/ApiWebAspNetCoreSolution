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
    }
}
