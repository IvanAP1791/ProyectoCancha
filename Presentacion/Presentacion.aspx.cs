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
    public partial class Presentacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CanchaNego canchaNego = new CanchaNego();

            Persona persona = new Persona();
            //persona.Nombre = "gaby";
            //persona.Apellido = "Milito";

            //canchaNego.GuardarCliente(persona);
            //Persona persona = new Persona();
            //CanchaNego canchaNego = new CanchaNego();

            //persona.Nombre = "Ivan";
            //persona.Apellido = "Palomeque";

            //canchaNego.GuardarPersona(persona);
            //persona.Apellido = "Maradona";
            //canchaNego.BorrarPersona(persona);
        }


    }
}