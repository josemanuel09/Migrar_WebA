using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrar_WebA.Shared.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }

        [Required(ErrorMessage = "El descripcion es obligatorio")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Los dias de comprimiso deben ser validos")]
        [Range(1, 31, ErrorMessage = "Los dias de comprimisos deben de estar entre 1 y 31")]
        public int DiasCompromiso { get; set; }
    }
}
