using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPP.Models
{
    public class Perro:PatronTabla
    {

        public string Raza { get; set; }
        public decimal Peso { get; set; }

    }
}