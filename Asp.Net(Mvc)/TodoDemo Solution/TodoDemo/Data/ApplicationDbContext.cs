using Microsoft.EntityFrameworkCore;
using TodoDemo.Models;

namespace TodoDemo.Data
{
    public class ApplicationDbContext : DbContext
    {

        // Classes inside Asp.Net Development Used For Dependcy Injection 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Connection String ");
        //}

        // fluent Api 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Todo>().Property(w => w.isFinished)
                .HasDefaultValue(false);
        }
        public DbSet<Todo> todos { get; set; }

    }
}
