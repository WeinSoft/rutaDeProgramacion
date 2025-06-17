using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using WebAPP.Models;

namespace WebAPP.UserCase
{
    public class GatoUserCase
    {

        private ApplicationDbContext _dbContext;
        public Gato _model { get; set; }
        public Tipos.Resultado _resultado;


        public GatoUserCase(string usuario)
        {
            _model = new Gato();
            
        }
        public GatoUserCase(int id, string usuario)
        {
            _model = new Gato();
            _model.Id = id;
        }

        public Tipos.Resultado Create()
        {
            Tipos.Resultado resultado = new Tipos.Resultado(Tipos.Enumeraciones._acciones.create);

            string excepcion = string.Empty;


            if (_dbContext == null)
                _dbContext = new ApplicationDbContext();

            try
            {

                _dbContext.Gatos.Add(_model);

                if (_dbContext.SaveChanges() > 0)
                {
                    resultado.ResultadoOk();
                }
                else
                {
                    resultado.ResultadoError();
                }
            }
            
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {

                    foreach (var ve in eve.ValidationErrors)
                    {
                        excepcion += $"Campo: {ve.PropertyName}, Error: {ve.ErrorMessage}; ";
                    }
                }

                _resultado.ResultadoExcepcion(excepcion);
            }
            catch (Exception ex)
            {
                excepcion = $"Se ha producido la siguiente excepción: {ex.InnerException.InnerException.Message}";
                _resultado.ResultadoExcepcion(excepcion);
            }
            finally
            {

            }

            return resultado;
        }

        //read
        public Tipos.Resultado Read()
        {
            Tipos.Resultado resultado = new Tipos.Resultado(Tipos.Enumeraciones._acciones.read);
            string excepcion = string.Empty;
            try
            {
                SetById();

                resultado.ResultadoOk();
            }
            catch (Exception ex)
            {
                excepcion = $"Se ha producido la siguiente excepción: {ex.InnerException.InnerException.Message}";
                _resultado.ResultadoExcepcion(excepcion);
            }

            return resultado;

        }
        //update
        public Tipos.Resultado Update()
        {
            Tipos.Resultado resultado = new Tipos.Resultado(Tipos.Enumeraciones._acciones.update);

            string excepcion = string.Empty;

            if (_dbContext == null)
                _dbContext = new ApplicationDbContext();

            try
            {

                if (_dbContext.SaveChanges() > 0)
                {
                    resultado.ResultadoOk();
                }
                else
                {
                    resultado.ResultadoError();

                }
            }

            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {

                    foreach (var ve in eve.ValidationErrors)
                    {
                        excepcion += $"Campo: {ve.PropertyName}, Error: {ve.ErrorMessage}; ";
                    }
                }

                _resultado.ResultadoExcepcion(excepcion);
            }
            catch (Exception ex)
            {
                excepcion = $"Se ha producido la siguiente excepción: {ex.InnerException.InnerException.Message}";
                _resultado.ResultadoExcepcion(excepcion);
            }
            finally
            {

            }

            return resultado;
        }

        //delete
        public Tipos.Resultado Delete()
        {
            Tipos.Resultado resultado = new Tipos.Resultado(Tipos.Enumeraciones._acciones.delete);

            string excepcion = string.Empty;

            if (_dbContext == null)
                _dbContext = new ApplicationDbContext();

            try
            {
                _dbContext.Gatos.Remove(_model);

                if (_dbContext.SaveChanges() > 0)
                {
                    resultado.ResultadoOk();
                }
                else
                {
                    resultado.ResultadoError();

                }
            }

            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {

                    foreach (var ve in eve.ValidationErrors)
                    {
                        excepcion += $"Campo: {ve.PropertyName}, Error: {ve.ErrorMessage}; ";
                    }
                }

                _resultado.ResultadoExcepcion(excepcion);
            }
            catch (Exception ex)
            {
                excepcion = $"Se ha producido la siguiente excepción: {ex.InnerException.InnerException.Message}";
                _resultado.ResultadoExcepcion(excepcion);
            }
            finally
            {

            }

            return resultado;
        }


        protected void SetById()
        {
            if (_dbContext == null)
                _dbContext = new ApplicationDbContext();

            _model = _dbContext
                .Gatos
                .FirstOrDefault(x => x.Id == _model.Id);

        }
    }
}