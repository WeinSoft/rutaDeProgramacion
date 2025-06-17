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

        }

        protected void btnCreateEntidad_Click(object sender, EventArgs e)
        {
            UserCase.GatoUserCase ucGato = new UserCase.GatoUserCase(string.Empty);
            
             ucGato.Create();

        }
    }
}