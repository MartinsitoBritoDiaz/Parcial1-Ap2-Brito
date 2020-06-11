using Parcial1_Ap2_Brito.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Brito.Models
{
    public class Articulos
    {
        [Key]
        public int articuloId { get; set; }

        [Required(ErrorMessage ="Debe introducir la descripción")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "Debe introducir la existencia")]
        public int existencia { get; set; }

        [Required(ErrorMessage = "Debe introducir el costo")]
        public double costo { get; set; }

        public double valorInventario { get; set; }
    }
}
