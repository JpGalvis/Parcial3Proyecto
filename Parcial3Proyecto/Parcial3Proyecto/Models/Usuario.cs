using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial3Proyecto.Models
{
    public class Usuario
    {
        [Key]
        public string Almacen { get; set; }
        [Display(Name = "Nombre del almacen")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El nombre debe contener entre 3 a 60 caracteres")]
        [Required(ErrorMessage = "producto")]
        public string Producto { get; set; }
        [Display(Name = "costo del producto")]
        public string Costo { get; set; }
        [Url]
        [Display(Name = "link")]
        public string link { get; set; }

    }
}
