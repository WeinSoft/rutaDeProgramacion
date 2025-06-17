using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAPP
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 3;
        }

        protected void btnCreateEntidad_Click(object sender, EventArgs e)
        {
            UserCase.GatoUserCase ucGato = new UserCase.GatoUserCase(string.Empty);

            ucGato._model.Raza = "Siames4";


            Tipos.Resultado resultado= ucGato.Create();
            
            if (resultado._resultadoAccion == Tipos.Enumeraciones._resultadoAccion.ok)
            {
                lblResultado.ForeColor = System.Drawing.Color.Aquamarine;
            }
            else if (resultado._resultadoAccion == Tipos.Enumeraciones._resultadoAccion.error)
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Brown;
            }

            lblResultado.Text = resultado._mensajeResultadoAccion;

        }
        protected void btnRead_Click(object sender, EventArgs e)
        {
            UserCase.GatoUserCase ucGato = new UserCase.GatoUserCase(3,string.Empty);
            Tipos.Resultado resultado= ucGato.Read();

            if (resultado._resultadoAccion == Tipos.Enumeraciones._resultadoAccion.ok)
            {
                lblResultado.ForeColor = System.Drawing.Color.Aquamarine;
            }
            else if (resultado._resultadoAccion == Tipos.Enumeraciones._resultadoAccion.error)
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Brown;
            }

            lblResultado.Text = resultado._mensajeResultadoAccion;

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            UserCase.GatoUserCase ucGato = new UserCase.GatoUserCase(3, string.Empty);
            ucGato.Read();
            ucGato._model.Raza = "Gato modificado";

            Tipos.Resultado resultado = ucGato.Update();

            if (resultado._resultadoAccion == Tipos.Enumeraciones._resultadoAccion.ok)
            {
                lblResultado.ForeColor = System.Drawing.Color.Aquamarine;
            }
            else if (resultado._resultadoAccion == Tipos.Enumeraciones._resultadoAccion.error)
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Brown;
            }

            lblResultado.Text = resultado._mensajeResultadoAccion;
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            UserCase.GatoUserCase ucGato = new UserCase.GatoUserCase(3, string.Empty);
            ucGato.Read();

            Tipos.Resultado resultado = ucGato.Delete();

            if (resultado._resultadoAccion == Tipos.Enumeraciones._resultadoAccion.ok)
            {
                lblResultado.ForeColor = System.Drawing.Color.Aquamarine;
            }
            else if (resultado._resultadoAccion == Tipos.Enumeraciones._resultadoAccion.error)
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Brown;
            }

            lblResultado.Text = resultado._mensajeResultadoAccion;
        }

    }
}