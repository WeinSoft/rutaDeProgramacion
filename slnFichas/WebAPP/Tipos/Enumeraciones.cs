using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPP.Tipos
{
    public class Enumeraciones
    {
        public enum _acciones {
            create,
            read,
            update,
            delete
        }
        public enum _resultadoAccion {
            ok,
            error,
            excepcion
        }

    }
}