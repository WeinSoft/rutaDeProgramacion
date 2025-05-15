using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnFase1
{
    public class Fases
    {
        public int numeroFase { get; private set; }
        public bool completado { get; set; }
        public int puntuacion { get; set; }

        int pvp = 2;
        int precio2 = 3;
        decimal resultado = 0;
        decimal impuesto = 0;
        bool Aaceptado = false;


        public Fases()
        {

            completado = false;
            puntuacion = 0;
        }

        public Fases(int noFase)
        {
            numeroFase = noFase;

        }

        public bool ValidarCookies()
        {
            if (Aaceptado)
            {
                IMprimeCOnsentimiento()
                ValidaLaVEnta()
                EnviaEmail()
            }
            else
            {

            }
        }

        public void IMprimeCOnsentimiento()
        {

        }


        public decimal CalcularElIVA(decimal importe, decimal impuestoAAplicar)
        {
            return (importe * impuestoAAplicar / 100) + importe;
        }

        public void CalcularElIVA(decimal importe, decimal impuestoAAplicar)
        {
            return   resultado= (importe * impuestoAAplicar / 100) + importe;

         
        }


        public string EjecutarLaFase()
        {
            Console.WriteLine("La fase ha inciado");

            AccionesAReaqlizar();

            return "Finzalizado";
        }


        private void AccionesAReaqlizar()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Estoy en la interacción {i}");
            }
        }
    }
}
