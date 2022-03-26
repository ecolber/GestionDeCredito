using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDeCredito.Models
{
    public class PrestamoPago
    {
        public PrestamoPago()
        {
            Clientes = new List<Cliente>();
            Prestamos = new List<Prestamo>();
            Pagos = new List<Pago>();
        }
        public List<Cliente> Clientes { set; get; }
        public List<Prestamo> Prestamos { set; get; }

        public List<Pago> Pagos { set; get; }
    }

}

