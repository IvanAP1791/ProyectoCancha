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
    public partial class ReservarTurno : System.Web.UI.Page
    {
        TurnoNego turnoNego = new TurnoNego();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GuardarTurno_Click(object sender, EventArgs e)
        {
            CargarTurno();

        }

        public void CargarTurno()
        {
            Turnos t1 = new Turnos();

            t1.NombreReserva = txtNombreDeReserva.Text;
            t1.Fecha = Convert.ToDateTime(txtFecha.Text);
            t1.FranjaHoraria1 = ddlFranjaHoraria.Text;
            t1.NumCancha1 = Convert.ToInt32(txtNumCancha.Text);
            t1.Estado = ddlEstado.Text;

            turnoNego.GuardarTurno(t1);

        }
    }
}