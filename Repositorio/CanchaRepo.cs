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

        
        public void GuardarCancha(Cancha cancha)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();

                string query = "INSERT INTO dbo.Cancha (numeroCancha, estado) VALUES  ('', '')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroCancha", cancha.NumeroCancha);
                cmd.Parameters.AddWithValue("@estado", cancha.Estado);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarCancha()
        {
            DataTable dt = new DataTable();

            String query = "SELECT * from Cancha";

            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public void BorrarCancha(Cancha cancha)
        {
            SqlConnection conn = new SqlConnection(cnn);
            {
                conn.Open();

                string query = "DELETE * FROM Cancha WHERE idCancha = @idCancha";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idcancha", cancha.IdCancha);

                cmd.ExecuteNonQuery();
            }
        }

        public void TraerCancha(Cancha cancha)
        {
            SqlConnection conn = new SqlConnection(cnn);
            {
                conn.Open();

                string query = "SELECT * FROM dbo.Cancha WHERE idCancha = @idCancha";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCancha", cancha.IdCancha);

                cmd.ExecuteNonQuery();
            }
        }

        public void EditarCancha(Cancha cancha)
        {
            SqlConnection conn = new SqlConnection(cnn);
            {
                conn.Open();

                string query = "UPDATE dbo.Cancha SET (numeroCancha=@numeroCancha,estado=@estado)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@numeroCancha", cancha.NumeroCancha);
                cmd.Parameters.AddWithValue("@estado", cancha.Estado);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

