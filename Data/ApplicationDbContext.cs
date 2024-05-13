using Microsoft.EntityFrameworkCore;
using Pry_CRUD.Models;

namespace Pry_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        //Agregar los modelos aqui
        //Cada modelo corresponde a una tabla en la BD
        public DbSet<Contacto> Contacto { get; set; }
    }
}
