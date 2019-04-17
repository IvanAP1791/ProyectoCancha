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
    public class CanchaRepo
    {
        string cnn = ConfigurationManager.ConnectionStrings["ConexionBaseDeDatos"].ConnectionString;

        public void GuardarCliente(Persona persona)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();
                //string query = "insert into Persona (nombre, apellido) values (@nombre, @apellido)";

                //string query = "INSERT INTO dbo.Cliente ( idCliente, nombre, apellido, edad, documento, direccion, correoElectronico, telefono  ) VALUES  ( '', '', '', '', '', '', '', '')";
                //SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                //cmd.Parameters.AddWithValue("@nombre", persona.Nombre);
                //cmd.Parameters.AddWithValue("@apellido", persona.Apellido);
                //cmd.Parameters.AddWithValue("@edad", cliente.Edad);
                //cmd.Parameters.AddWithValue("@documento", cliente.Documento);
                //cmd.Parameters.AddWithValue("@dirrecion", cliente.Direccion);
                //cmd.Parameters.AddWithValue("@correoElectronico", cliente.CorreoElectronico);
                //cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);

                //cmd.ExecuteNonQuery();

            }

        }
        public void GuardarCancha(Cancha cancha)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();

                string query = "INSERT INTO dbo.Cancha ( numeroCancha, estado  ) VALUES  ( '', '')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroCanche", cancha.NumeroCancha);
                cmd.Parameters.AddWithValue("@numeroCanche", cancha.Estado);
            }
        }
        public void GuardarEncargado(Encargado encargado)
        {

        }

        public void BorrarPersona(Persona persona)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();

                string query = "delete from persona where apellido = @apellido";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@apellido", persona.Apellido);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

