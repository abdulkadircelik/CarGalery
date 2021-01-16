using CarGalery.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGalery.DataAccess.Concrete.EntityFramework
{
    public class CarGaleryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder 
            optionsBuilder)
        {
            optionsBuilder
               .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Car> Cars { get; set; }
    }
}
