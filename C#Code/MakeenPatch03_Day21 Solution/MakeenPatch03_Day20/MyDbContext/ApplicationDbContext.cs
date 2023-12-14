using MakeenPatch03_Day20.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day20.MyDbContext
{
    //manage all my Connection and transactions with my Database 
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection String ==> " key = value ;  " 
            //Connection String ==> " Data Source = DESKTOP-L6SQVCF ; initial Catalog = Companyxyz ; integerated security = True   "  // Windows Authentication
            //Connection String ==> " Data Source = . ; initial Catalog = Companyxyz ; Username =  password = ;  "  // Sql Login 
            //Connection String ==> " Server Name =  ; Database name =    "
            optionsBuilder.UseSqlServer("Data Source= . ;Initial Catalog=JoonguiniCompany; Integrated Security=True;");
            
        }

        // using fluent api 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projects>().
                Property(x => x.Name).
                IsRequired().
                HasMaxLength(50);
            //modelBuilder.Entity<Employee>().
            //    Property(w=>w.)
           
            modelBuilder.Entity<Employee>()
                .HasOne<Department>()
                .WithMany();
            modelBuilder.Entity<Department>()
                .HasMany<Employee>()
                .WithOne();

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Projects> Projects { get; set; }


    }
}
