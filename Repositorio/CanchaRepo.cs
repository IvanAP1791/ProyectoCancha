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

                string query = "INSERT INTO dbo.Cancha ( numeroCancha, estado  ) VALUES  ( '', '')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroCanche", cancha.NumeroCancha);
                cmd.Parameters.AddWithValue("@numeroCanche", cancha.Estado);
            }
        }
        public void GuardarEncargado(Encargado encargado)
        {

        }



        public DataSet LlenarGrilla()
        {
            DataSet ds = new DataSet();
            //SqlConnection con = new SqlConnection(cnn);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Persona", con);

            //da.Fill(ds);

            return ds;
        }
    }
}

