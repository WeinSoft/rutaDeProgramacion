using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPP.Models;

namespace WebAPP.UserCase
{
    public class GatoUserCase
    {

        private ApplicationDbContext _dbContext;

        public Gato _model { get; set; }


        public GatoUserCase(string usuario)
        {
            _model = new Gato();
        }
        public GatoUserCase(int id, string usuario)
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
                _model.Raza = "Europeo común";

                _dbContext.Gatos.Add(_model);

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