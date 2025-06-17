using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPP.Models;

namespace WebAPP.UserCase
{
    public class EntidadUserCase
    {
        //public string _usuario { get; set; }

        private ApplicationDbContext _dbContext;

        public Entidad _model { get; set; }


        public EntidadUserCase(string usuario)
        {
            _model = new Entidad();
        }
        public EntidadUserCase(int id, string usuario)
        {
         //   _Model = GetById();
        }

        public int Create()
        {

            int resultado = 0;

            if (_dbContext == null)
                _dbContext = new ApplicationDbContext();

            try
            {
                _model.FechaAdd = DateTime.Now;
                _model.FechaUpdate = Convert.ToDateTime("01/01/1900");
                _model.FechaDelete = Convert.ToDateTime("01/01/1900");
                _model.Nombre = "Entidad de prueba";

                _dbContext.Entidades.Add(_model);

                if (_dbContext.SaveChanges() > 0)
                {
                    resultado = _model.Id;
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido la siguiente Excepción: {ex.Message}");
            }

            return resultado;
        }

    }
}