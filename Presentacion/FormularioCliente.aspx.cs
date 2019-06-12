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
    public partial class FormularioCliente : System.Web.UI.Page
    {
        ClienteNego clienteNego = new ClienteNego();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }
        public void GuardarCliente()
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Edad = Convert.ToInt32(txtEdad.Text);
            cliente.Documento = txtDocumento.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.CorreoElectronico = txtCorreo.Text;
            cliente.Telefono = Convert.ToInt32(txtTelefono.Text);
            //cliente.Socio = CbxSi.Checked;

            //if (CbxSi.Checked) 
            //    cliente.Socio = true

            clienteNego.GuardarCliente(cliente);

            Response.Redirect("./ListarCliente.aspx");

        }
      

    }
}