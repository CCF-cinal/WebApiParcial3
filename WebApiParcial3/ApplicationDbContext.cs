using Microsoft.EntityFrameworkCore;
using WebApiParcial3.Entidades;

namespace WebApiParcial3
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Depa> Departamentos { get; set; }
    }
}
