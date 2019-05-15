using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;


namespace Presentacion
{
    public partial class Grilla : System.Web.UI.Page
    {
        ClienteNego clienteNego = new ClienteNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarCombo();
            //CanchaNego canchaNego = new CanchaNego();
            //gdvGrilla.DataSource = canchaNego.LlenarGrilla();
            //gdvGrilla.DataBind();
            ////Response.Redirect()
        }

        protected void ddlDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string texto = ddlDocumento.SelectedItem.Text;
            string valor = ddlDocumento.SelectedItem.Value;
            txtDocumento.Text = ddlDocumento.SelectedItem.Text;

        }

        //protected void Unnamed_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string texto = ddlDocumento.SelectedItem.Text;
        //    string valor = ddlDocumento.SelectedItem.Value;
        //    txtDocumento.Text = ddlDocumento.SelectedItem.Text; 
        //}
        protected void CargarCombo()
        {
            //List<String> listaString = new List<string>();
            //listaString.Add("Perro");
            //listaString.Add("Gato");
            List<ListarCliente> listaCliente = new List<ListarCliente>();

            ddlDocumento.DataSource = listaCliente;//clienteNego.ListarCliente();
            //ddlDocumento.DataBind();
            ddlDocumento.DataTextField = "nombre";//clienteNego.ListarCliente().Columns["nombre"].ToString();
            ddlDocumento.DataValueField = "idCliente";/*clienteNego.ListarCliente().Columns["idCliente"].ToString();*/
            ddlDocumento.DataBind();
        }
    }


}