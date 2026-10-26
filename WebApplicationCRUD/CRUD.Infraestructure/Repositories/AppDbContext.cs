using Microsoft.EntityFrameworkCore;

namespace WebApplicationCRUD.CRUD.Infraestructure.Repositories
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
                
        }
    }
}
