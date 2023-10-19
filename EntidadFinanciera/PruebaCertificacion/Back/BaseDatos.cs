using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    internal class BaseDatos : DbContext
    {
        public DbSet<Cliente> Cliente {  get; set; }
        public DbSet<CuentaBancaria> cuentaBancaria { get; set; }
        public DbSet<TarjetaCredito> tarjetaCredito { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlServer("server=.;database=pruebaDOTNET;trusted_connection=true;Encrypt=False");

        }
    }
}
