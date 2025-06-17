using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPP.Tipos
{
    public class Resultado
    {
        public Tipos.Enumeraciones._acciones _accion;
        public Tipos.Enumeraciones._resultadoAccion _resultadoAccion;
        public string _mensajeResultadoAccion = string.Empty;


        public Resultado(Enumeraciones._acciones accion)
        {
            _accion = accion;
        }

        public void ResultadoOk()
        {
            _resultadoAccion = Enumeraciones._resultadoAccion.ok;
            _mensajeResultadoAccion = $"Se ha {_accion.ToString()} con éxito";
        }
        public void ResultadoError()
        {
            _resultadoAccion = Enumeraciones._resultadoAccion.error;
            _mensajeResultadoAccion = $"Se ha producido un error en la acción {_accion.ToString()}";
        }
        public void ResultadoExcepcion(string excepcion)
        {
            _resultadoAccion = Enumeraciones._resultadoAccion.excepcion;
            _mensajeResultadoAccion = $"Se ha producido la siguiente excepcion: {excepcion}";
        }
    }
}