using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnFase1
{
    class Program
    {

       
        static void Main(string[] args)
        {
            foreach (string a in args)
            {

                if (a.ToLower() == "saludo")
                {

                    Fases gestorDeVenta = new Fases(4);

                    gestorDeVenta.EjecutarLaFase();


                                      

                }
                else if (a.ToLower() == "despedida")
                {
                   
                }
                else
                {
                   
                }
            }

        }

    }    

}
