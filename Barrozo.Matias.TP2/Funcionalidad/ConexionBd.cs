using Microsoft.Data.SqlClient;

namespace Funcionalidad
{
    public static class ConexionBd
    {
        private static string stringconexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static ConexionBd()
        {
            stringconexion = @"Server = localhost ; Database = generalaDb ; Trusted_Connection=True; Encrypt= False ";
            conexion = new SqlConnection(stringconexion);
            comando = new SqlCommand();
        }

        public static List<Usuario> ObtenerDatos()
        {
            List<Usuario> clientes = new List<Usuario>();


            conexion.Open();


            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM usuario_test";

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clientes.Add(new Usuario(reader.GetString(1), reader.GetString(2),reader.GetString(3),reader.GetString(4)));
            }

            conexion.Close();
            return clientes;
        }

        public static void GuardarPartida(Partida partida)
        {
            try
            {
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO partidas_test VALUES (@Nombre,@Cantidad,@date)";

                comando.Parameters.AddWithValue("@Nombre", partida.Ganador);
                comando.Parameters.AddWithValue("@Cantidad", partida.Jugadores.Count());
                comando.Parameters.AddWithValue("@Date", partida.Date);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Partida> ObtenerDatosPartida()
        {
            List<Partida> partidas = new List<Partida>();


            conexion.Open();


            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM partidas_test";

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                partidas.Add(new Partida(reader.GetString(1),reader.GetInt32(2),reader.GetDateTime(3),reader.GetInt32(0)));
            }

            conexion.Close();
            return partidas;
        }

    }
}