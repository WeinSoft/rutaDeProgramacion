using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPP.Models
{
    public abstract class PatronTabla
    {
        public int Id { get; set; }

        public DateTime FechaAdd { get; set; }
        public DateTime FechaUpdate { get; set; }
        public DateTime FechaDelete { get; set; }


    }
}