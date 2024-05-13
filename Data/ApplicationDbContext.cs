using Microsoft.EntityFrameworkCore;

namespace Pry_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        //Agregar los modelos aqui
        //Cada modelo corresponde a una tabla en la BD
    }
}
