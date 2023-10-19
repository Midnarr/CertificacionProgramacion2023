using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Principal
    {
        BaseDatos context = new BaseDatos();


        public void AgregarCliente(Cliente nuevoCliente)
        {
            context.Cliente.Add(nuevoCliente);
            context.SaveChanges();
        }

        public void CrearCuentaBancaria(CuentaBancaria cliente)
        {
            context.cuentaBancaria.Add(cliente);
            context.SaveChanges();

        }

        public void EmitirTarjetaCredito(TarjetaCredito cliente)
        {
            context.tarjetaCredito.Add(cliente);
            context.SaveChanges();
        }
    }
}
