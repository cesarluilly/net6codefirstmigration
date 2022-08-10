using Microsoft.EntityFrameworkCore;
using net6codefirstmigration.Entidad;

namespace net6codefirstmigration
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Genero> Genero { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
