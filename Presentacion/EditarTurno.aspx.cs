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
    public partial class EditarTurno : System.Web.UI.Page
    {
        Turnos turnos = new Turnos();
        TurnoNego turnoNego = new TurnoNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            string turnos_Id = Request["turnos_Id"].ToString();

            if (!Page.IsPostBack)
            {
                RellenarCampos();
            }
                

        }

        protected void RellenarCampos()
        {
            if (Request.QueryString["turnos_Id"] != null) {
                txtNombreDeReserva.Text = turnos.NombreReserva;
                //txtFecha.Text = Convert.ToDateTime(turnos.Fecha);
                txtNumCancha.Text = turnos.NumCancha1.ToString();
                ddlEstado.Text = turnos.Estado;
                ddlFranjaHoraria.Text = turnos.FranjaHoraria1;
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e) {

        }
    }
}