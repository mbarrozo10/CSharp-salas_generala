using Microsoft.Data.SqlClient;
using System.Collections.Concurrent;

namespace Funcionalidad.clases
{
    public class ConexionBdPartidas
    {
        private static string stringConexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static ConexionBdPartidas()
        {
            stringConexion = @"Server = localhost ; Database = generalaDb ; Trusted_Connection=True; Encrypt= False ";
            conexion = new SqlConnection(stringConexion);
            comando = new SqlCommand();
        }

       

        public void GuardarPartida(Partida partida)
        {
            try
            {
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO partidas_test VALUES (@Nombre,@Cantidad,@date,@estado)";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", partida.Ganador);
                comando.Parameters.AddWithValue("@Cantidad", partida.Jugadores.Count());
                comando.Parameters.AddWithValue("@date", partida.Date);
                comando.Parameters.AddWithValue("@estado", partida.Estado);

                comando.ExecuteNonQuery();

                conexion.Close();


            }
            catch (Exception)
            {
                throw;
            }

        }

        public  ConcurrentBag<Partida> ObtenerDatosPartidaBag()
        {
            ConcurrentBag<Partida> partidas = new ConcurrentBag<Partida>();


            conexion.Open();


            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM partidas_test";

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                partidas.Add(new Partida(reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetInt32(0),0, reader.GetString(4)));
            }

            conexion.Close();
            return partidas;
        }
        public int ObtenerUltimoId()
        {
            int id=0;
            
            conexion.Open();


            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT TOP(1) id FROM partidas_test ORDER BY id DESC";

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                id= reader.GetInt32(0);
            }
            conexion.Close();
            return id;
        }

        public string ConseguirEstadisticasDePartidas(string query)
        {
            int cantidad=0;

            conexion.Open();


            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cantidad = reader.GetInt32(0);
            }
            conexion.Close();
            return cantidad.ToString();
        }
    }
}