using GestionDeCredito.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCredito.Data
{
    public class MyDBContext : DbContext 
    {

          public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Prestamo> Prestamo { get; set; }

        public DbSet<Pago> Pago { get; set; }

    }
}
