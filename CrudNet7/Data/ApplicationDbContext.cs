using CrudNet7.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace CrudNet7.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        //agregar modelos
        public DbSet<Contacto> Contacto { get; set; }

    }
}
