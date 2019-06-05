using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class CrearCancha : System.Web.UI.Page
    {
        CanchaNego canchaNego = new CanchaNego();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarCancha_Click(object sender, EventArgs e)
        {
            GuardarCancha();
        }

        public void GuardarCancha()
        {
            Cancha cancha = new Cancha();

            cancha.NumeroCancha = Convert.ToInt32(txtNumeroCancha.Text);
            cancha.Estado = CbxSi.Checked;
            if (CbxSi.Checked)
            {
                cancha.Estado = true;
            }
           
            canchaNego.GuardarCancha(cancha);
            Response.Redirect("./ListarCancha.aspx");
        }
    }
}