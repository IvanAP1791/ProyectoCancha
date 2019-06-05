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
    public class TurnoRepo
    {
        string cnn = ConfigurationManager.ConnectionStrings["ConexionBaseDeDatos"].ConnectionString;

        public void GuardarTurno(Turnos turnos)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();

                string query = "INSERT INTO dbo.Turno ( nombreReserva, fecha, NumCancha, estado, franjaHoraria ) VALUES  (@nombreReserva, @fecha, @NumCancha, @estado, @franjaHoraria)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombreReserva", turnos.NombreReserva);
                cmd.Parameters.AddWithValue("@franjaHoraria", turnos.FranjaHoraria1);
                cmd.Parameters.AddWithValue("@fecha",turnos.Fecha);
                cmd.Parameters.AddWithValue("@NumCancha", turnos.NumCancha1);
                cmd.Parameters.AddWithValue("@estado", turnos.Estado);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void BorrarTurno(Turnos turnos)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();

                string query = "DELETE * FROM dbo.Turno WHERE nombreReserva=@nombreReserva" ;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombreReserva", turnos.NombreReserva);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void EditarTurno(Turnos turnos)
        {

            SqlConnection conn = new SqlConnection(cnn);
            {
                conn.Open();

                string query = "UPDATE dbo.Turno SET (nombreReserva=@nombreReserva, fecha=@fecha, NumCancha=@NumCancha, estado=@estado, franjaHoraria=@franjaHoraria )";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombreReserva", turnos.NombreReserva);
                cmd.Parameters.AddWithValue("@fecha", turnos.Fecha);
                cmd.Parameters.AddWithValue("@NumCancha", turnos.NumCancha1);
                cmd.Parameters.AddWithValue("@estado", turnos.Estado);
                cmd.Parameters.AddWithValue("@FranjaHoraria", turnos.FranjaHoraria1);


                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

    }
}
