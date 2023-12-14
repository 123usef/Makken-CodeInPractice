using MakeenPatch03_Day19.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenPatch03_Day19.MyDbContext
{
     class ApplicationDbContext : DbContext
    {
        // initialize a Connection Inside the Database 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   //                          // Connection String
            optionsBuilder.UseSqlServer("Data Source= DESKTOP-L6SQVCF ;Initial Catalog=MakeenCompany;Integrated Security=True; ");
            //optionsBuilder.UseSqlServer("Data Source= DESKTOP-L6SQVCF ;Initial Catalog=MakeenCompany; user = SA , password = 123456 ; ");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
