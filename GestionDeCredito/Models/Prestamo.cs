using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDeCredito.Models
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }

        
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }

        public Double Monto { get; set; }

        public Double Interes { get; set; }

        public int Plazo { get; set; }

        [StringLength(15)]
        public string Estado { get; set; }

        [StringLength(25)]
        public string FechaCreacion { get; set; }

        public Double Saldo { get; set; }

    }
}
