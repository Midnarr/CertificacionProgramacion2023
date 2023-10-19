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
            context.cliente.Add(nuevoCliente);
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

        public void RealizarDeposito(CuentaBancaria cuenta,int deposito)
        {
            var cuentaEncontrada = context.cuentaBancaria.Find(cuenta.id);
            if(cuentaEncontrada != null)
            {
                cuentaEncontrada.saldo += deposito;
                context.SaveChanges();
            }
        }

        public void PausarTarjetaCredito(TarjetaCredito tarjeta)
        {
            var tarjetaEncontrada = context.tarjetaCredito.Find(tarjeta.id);
            if (tarjetaEncontrada != null & tarjeta.estado!="activo")
            {
                //FALTA TERMINAR
                context.SaveChanges();
            }


        }


    }
}
