using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDeCredito.Models
{
    public class Pago
    {
        [Key]
        public int Id { get; set; }

        public int IdPrestamo { get; set; }

        [ForeignKey("IdPrestamo")]
        public Prestamo Prestamo { get; set; }

        public Double MontoPagado { get; set; }

        public DateTime FechaPago { get; set; }
    }
}
