using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryContext : DbContext
    {
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=password123;Database=ORMLibrary";

            optionsBuilder.UseNpgsql(connectionString)
                .UseSnakeCaseNamingConvention();
        }
    }
}
