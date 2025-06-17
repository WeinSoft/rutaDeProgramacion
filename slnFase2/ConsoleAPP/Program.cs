using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace ConsoleAPP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CuentaBancaria bbva = new CuentaBancaria(15);

            //CUanto quiere usted deposita
            //si la cnatidad 
            bbva.depositar(10);

            // si el cliente quiere sacar dinero

            Console.WriteLine($"El cliente tienda {bbva.obtenerSaldo()}€ en su cuenta");

            Console.Read();

            //bbva.LLamarABAseDeDatos();

        }
    }
}
