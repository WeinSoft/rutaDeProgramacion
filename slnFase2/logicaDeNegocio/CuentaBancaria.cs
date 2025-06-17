using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaDeNegocio
{
    public class CuentaBancaria
    {
        private decimal _saldo;

        public CuentaBancaria(decimal saldo)
        {
            _saldo = saldo;
        }

        public void Depositar(decimal cantidad)
        {

            if (cantidad > 0)
            {
                _saldo += cantidad;

                LLamarABAseDeDatos();
            }
        }

        public decimal ObtenerSaldo()
        {
            return _saldo;
        }

        public void LLamarABAseDeDatos()
        {
            //Conetcta con el banco
            
            // ontiene la base de datos de las cuentas
            
            // modoifica el valor
            
            //llama a hacienda
            
            // 
        }

    }
}
