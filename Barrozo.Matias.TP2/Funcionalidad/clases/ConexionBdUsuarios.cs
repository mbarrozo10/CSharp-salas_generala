using Funcionalidad.clases;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public class ConexionBdUsuarios
    {
        private static string stringConexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static ConexionBdUsuarios()
        {
            stringConexion = @"Server = localhost ; Database = generalaDb ; Trusted_Connection=True; Encrypt= False ";
            conexion = new SqlConnection(stringConexion);
            comando = new SqlCommand();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                conexion.Open();


                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM usuario_test";

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    usuarios.Add(new Usuario(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(0), EEstado.libre, reader.GetInt32(5)));
                }

                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                throw;
            }
            return usuarios;
        }

        public void ActualizarPartidasGanadas(Usuario usuario)
        {
            try
            {
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "UPDATE usuario_test SET PartidasGanadas=@ganadas WHERE Id = @id";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ganadas", usuario.PartiasGanadas);
                comando.Parameters.AddWithValue("@id", usuario.Id);

                comando.ExecuteNonQuery();

                conexion.Close();


            }
            catch (Exception)
            {
                conexion.Close();
                throw;
            }

        }
        public void GuardarUsuarios(Usuario usuario, string contraseña)
        {
            try
            {
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO usuario_test VALUES (@Nombre,@Apellido,@Usuario,@Contraseña,@Ganadas)";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                comando.Parameters.AddWithValue("@Usuario", usuario.User);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                comando.Parameters.AddWithValue("@Ganadas", usuario.PartiasGanadas);

                comando.ExecuteNonQuery();

                conexion.Close();


            }
            catch (Exception)
            {
                conexion.Close();
                throw;
            }

        }

        public List<Usuario> ObtenerTop()
        {
            List<Usuario> usuarios = new List<Usuario>();

            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT TOP(5) * FROM usuario_test ORDER BY PartidasGanadas DESC";

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                usuarios.Add(new Usuario(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(0), EEstado.libre, reader.GetInt32(5)));
            }

            conexion.Close();


            return usuarios;
        }
    }

}
