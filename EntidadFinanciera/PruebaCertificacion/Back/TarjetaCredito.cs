using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class TarjetaCredito
    {
        public int id {  get; set; }
        public int numTarjeta {  get; set; }
        public int limiteCredito {  get; set; }
        public int saldoDisponible {  get; set; }
        public string estado {  get; set; }
        public Cliente cliente { get; set; }
    }
}
