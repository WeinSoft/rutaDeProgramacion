using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPP.Models
{
    public class Log:PatronTabla
    {
        [Required(ErrorMessage="La Fecha del LOG es Obligatoria")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La Tabla del LOG es Obligatoria")]
        public string Tabla { get; set; }
        [Required(ErrorMessage = "El TableId del LOG es Obligatoria")]
        public int TablaId { get; set; }
        [Required(ErrorMessage = "La Acción del LOG es Obligatoria")]
        public string Accion { get; set; }
        [Required(ErrorMessage = "El Resultado de la Acción del LOG es Obligatoria")]
        public string ResultadoAccion { get; set; }
        [Required(ErrorMessage = "El Usuario del LOG es Obligatoria")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "El UserId del LOG es Obligatoria")]
        public string UserId { get; set; }
        public string Descripcion { get; set; }

    }
}