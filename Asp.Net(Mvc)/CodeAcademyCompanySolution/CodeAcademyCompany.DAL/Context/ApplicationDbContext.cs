using CodeAcademyCompany.DAL.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyCompany.DAL.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ):base(options)
        {
            
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        //public DbSet<ApplicationUser> User { get; set; }
        //public DbSet<IdentitUsery> User { get; set; }
        //public DbSet<IdentityRole> UserRole { get; set; }
    }
}
