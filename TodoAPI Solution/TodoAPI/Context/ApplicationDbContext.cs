using Microsoft.EntityFrameworkCore;
using TodoAPI.Model;

namespace TodoAPI.Context
{
	public class ApplicationDbContext :DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        {
            
        }

       public DbSet<Todo> todos { get; set; } 
    }
}
