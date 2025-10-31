using Microsoft.EntityFrameworkCore;
using ORMapi.Modelo;

namespace ORMapi.Data
{
    public class DataContext
    {
        public class DataContext : DbContext

        {

            public DataContext(DbContextOptions<DataContext> options) : base(options)

            {



            }

            public DbSet<Employee> Employees { get; set; }

            public DbSet<Categories> Categories { get; set; }

            public DbSet<Products> Products { get; set; }

        }
    }
}
