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
    public partial class EditarCliente : System.Web.UI.Page
    {
        Cliente cliente = new Cliente();
        ClienteNego clienteNego = new ClienteNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            string idCliente = Request["idCliente"].ToString();

            if (!Page.IsPostBack)
            {

                RellenaCampos(); //si es la primera vez que carga la pagina rellena los campos

            }
        }

        protected void RellenaCampos()
        {
            if (Request.QueryString["idCliente"] != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEdad.Text = cliente.Edad.ToString();
                txtDocumento.Text = cliente.Documento;
                txtDireccion.Text = cliente.Direccion;
                txtCorreo.Text = cliente.CorreoElectronico;
                txtTelefono.Text = cliente.Telefono.ToString();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = txtNombre.Text;  
            cliente.Apellido = txtApellido.Text;
            cliente.Edad = Convert.ToInt32(txtEdad.Text);
            cliente.Documento = txtDocumento.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.CorreoElectronico = txtCorreo.Text;
            cliente.Telefono = Convert.ToInt32(txtTelefono.Text);

            clienteNego.GuardarCliente(cliente);
            
        }
    }
}