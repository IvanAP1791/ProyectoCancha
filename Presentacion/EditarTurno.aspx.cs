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
            if(Request.QueryString["turnos_Id"] != null)
            {
                int turnos_Id = Convert.ToInt32(Request.QueryString["turnos_Id"]);
                Turnos turnos = turnoNego.BuscarTurnoPorId(turnos_Id);

                txtNombreReserva.Text = turnos.NombreReserva;
                txtFecha.Text = turnos.Fecha.ToString();
                txtNumCancha.Text = turnos.NumCancha1.ToString();
                ddlEstado.Text = turnos.Estado;
                ddlFranjaHoraria.Text = turnos.FranjaHoraria1;
               
                                
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int turnos_Id = Convert.ToInt32(Request.QueryString["turnos_Id"]);

            turnos.Turnos_Id = turnos_Id;
            turnos.NombreReserva = txtNombreReserva.Text;
            turnos.Fecha = Convert.ToDateTime(txtFecha.Text);
            turnos.NumCancha1 = txtNumCancha.Text;
            turnos.Estado = ddlEstado.Text;
            turnos.FranjaHoraria1 = ddlFranjaHoraria.Text;
            

            turnoNego.ModificarTurno(turnos);

            Response.Redirect("./ListarTurno.aspx");
        }

    }
}