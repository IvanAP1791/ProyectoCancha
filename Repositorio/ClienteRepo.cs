using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dominio;

namespace Repositorio
{
    public class ClienteRepo
    {

        string cnn = ConfigurationManager.ConnectionStrings["ConexionBaseDeDatos"].ConnectionString;

        public DataTable ListarCliente()
        {
            DataTable dataTable = new DataTable();

            String query = "SELECT * from Cliente";

            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            //toma el datatable y mete lo que traigamos de la query
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dataTable);

            conn.Close();

            return dataTable;
        }


        public void GuardarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();

                string query = "INSERT INTO dbo.Cliente (  nombre, apellido, edad, documento, direccion, correoElectronico, telefono  ) VALUES  (  @nombre, @apellido, @edad, @documento, @direccion, @correoElectronico, @telefono)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@edad", cliente.Edad);
                cmd.Parameters.AddWithValue("@documento", cliente.Documento);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@correoElectronico", cliente.CorreoElectronico);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);

                cmd.ExecuteNonQuery();

            }

        }
        public void BorrarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();

                string query = "DELETE FROM dbo.Cliente WHERE idCliente = @idCliente";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(cnn);
            {
                conn.Open();

                string query = "SELECT * FROM dbo.Cliente WHERE idCliente = @idCliente ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                cmd.ExecuteNonQuery();//Retornar objeto cliente
            }
        }

        public void ModificarCliente(Cliente cliente)
        {

            SqlConnection conn = new SqlConnection(cnn);
            {
                conn.Open();

                string query = "UPDATE dbo.Cliente SET  nombre = @nombre, apellido = @apellido, edad = @edad, documento = @documento, direccion = @direccion, correoElectronico = @correoElectronico, telefono = @telefono WHERE idCliente = @idCliente";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@edad", cliente.Edad);
                cmd.Parameters.AddWithValue("@documento", cliente.Documento);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@correoElectronico", cliente.CorreoElectronico);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);

                cmd.ExecuteNonQuery();
            }
        }
        public Cliente BuscarClientePorID(int idCliente)
        {
            Cliente cliente = new Cliente();

            SqlDataReader sdr = null;

            string query = "SELECT * FROM Cliente WHERE idCliente = @idCliente";

            SqlConnection conn = new SqlConnection(cnn);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                sdr = cmd.ExecuteReader();

                sdr.Read();

                cliente.IdCliente = Convert.ToInt32(sdr["IdCliente"].ToString());
                cliente.Nombre = sdr["Nombre"].ToString();
                cliente.Apellido = sdr["Apellido"].ToString();
                cliente.Edad = Convert.ToInt32(sdr["Edad"].ToString());
                cliente.Documento = sdr["Documento"].ToString();
                cliente.Direccion = sdr["Direccion"].ToString();
                cliente.CorreoElectronico = sdr["CorreoElectronico"].ToString();
                cliente.Telefono = Convert.ToInt32(sdr["Telefono"].ToString());

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                conn.Close();
            }
            return cliente;
        }
    }
}