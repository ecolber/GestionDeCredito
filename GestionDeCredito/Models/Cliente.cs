using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDeCredito.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="El campo nombre es requerido")]
        public string Nombre { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="El campo apellido es requerido")]
        public string Apellido { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "El campo direccion es requerido")]
        public string Direccion { get; set; }

        [StringLength(8)]
        public string Telefono { get; set; }

        [StringLength(1)]
        public string Genero { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage ="El campo cedula es requerido")]
        public string Cedula { get; set; }

        public int IdUsuario { get; set; }

        [StringLength(25)]
        public string FechaCreacion { get; set; }
    }
}
