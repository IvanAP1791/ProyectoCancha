using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion
{
    public partial class ListarCancha : System.Web.UI.Page
    {
        CanchaNego canchaNego = new CanchaNego();  
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            SubirCancha();
        }

        private void SubirCancha()
        {
            GridViewTablaCliente.DataSource = canchaNego.ListarCancha();
            GridViewTablaCliente.DataBind();
        }
    }
}