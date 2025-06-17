using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CuentaBancaria
    {
        private decimal _saldo;
        
        public CuentaBancaria(decimal cantidad)
        {
            _saldo = cantidad;
        }

        public void depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                _saldo += cantidad;
            }
        }

        public decimal obtenerSaldo()
        {
            return _saldo;
        }
    }
}
