using Microsoft.EntityFrameworkCore;
using MyTodoList.Models;

namespace MyTodoList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }






        // Dbsets (models)
        public DbSet<Todo> Todos { get; set; }

    }
}
