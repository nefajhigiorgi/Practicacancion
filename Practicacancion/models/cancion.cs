using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practicacancion.models
{
    public class Cancion
    {
        [Key]
        public string Titulo { get; set; }
        [Required]
        public string Autor { get; set; }
        [Required]
        public string Letra { get; set; }
        [Required]
        public string Enlace { get; set; }

    }
}
