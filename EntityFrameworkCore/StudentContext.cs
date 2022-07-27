using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore
{
    public class StudentContext : DbContext
    {
        public StudentContext() // constructor
        {

        }

        // protected override was found here: https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli#create-the-model
        protected override void OnConfiguring(DbContextOptionsBuilder options) // connects to SQLServer
        {
            // EF Connection Strings found here: https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings#aspnet-core
            // Server = The server we are connecting to. LocalDB is included with VS
            // Database = The desired name for the database
            // Trusted_Connection indicates that our windows account should be used 
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EntityFrameworkCoreDB;Trusted_Connection=True;");
        }

        // Tell EF Core to track students in the database
        public DbSet<Student> Students { get; set; }
    }
}
