using Funcionalidad;
using Funcionalidad.clases;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad_test
{
    [TestClass]
    public class ConexionBdUsuarios_Test
    {

        [TestMethod]
        public void ObtenerUsuarios_Success()
        {
            List<Usuario> usuarios;
            ConexionBdUsuarios conexion = new();

            usuarios= conexion.ObtenerUsuarios();

            Assert.IsNotNull(usuarios);
            Assert.IsTrue(usuarios.Count > 0);
        }
        
        [TestMethod]
        public void ActualizarPartidasGanadas_Success()
        {
            Usuario usuario = new Usuario("usuarioPrueba","test","usuarioTest","123",1,EEstado.libre,0);
            ConexionBdUsuarios conexion = new();
            Usuario usuarioBD;

            conexion.GuardarUsuarios(usuario, "123");
            usuario.PartiasGanadas++;
            conexion.ActualizarPartidasGanadas(usuario);
            usuarioBD = ObtenerUsuario(@"SELECT * FROM usuario_test WHERE Usuario= @usuario", usuario.User);

            Assert.AreNotEqual(usuarioBD.PartiasGanadas, usuario.PartiasGanadas);

            BorrarUsuario(@"DELETE FROM usuario_test WHERE Usuario= @usuario", usuario.User);
        }


        //public void CrearTablaTest(string comando)
        //{
        //    SqlConnection conexion = new SqlConnection(@"Server = localhost ; Database = generalaDb ; Trusted_Connection=True; Encrypt= False ");
        //    SqlCommand cmd = conexion.CreateCommand();

        //    conexion.Open();

        //    cmd.Connection = conexion;
        //    cmd.CommandType = System.Data.CommandType.Text;
        //    //cmd.CommandText = "CREATE TABLE usuarioTest SELECT * FROM usuario_test";
        //    cmd.CommandText = comando;

        //    cmd.ExecuteNonQuery();

        //    conexion.Close();
        //}

        public void BorrarUsuario(string comando, string parametro)
        {
            SqlConnection conexion = new SqlConnection(@"Server = localhost ; Database = generalaDb ; Trusted_Connection=True; Encrypt= False ");
            SqlCommand cmd = conexion.CreateCommand();

            conexion.Open();

            cmd.Connection = conexion;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = comando;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@parameter", parametro);

            cmd.ExecuteNonQuery();
        }

        public Usuario ObtenerUsuario(string comando,string parametro)
        {
            Usuario usuarios = null;
            SqlConnection conexion = new SqlConnection(@"Server = localhost ; Database = generalaDb ; Trusted_Connection=True; Encrypt= False ");
            SqlCommand cmd = conexion.CreateCommand();
            conexion.Open();

            cmd.Connection = conexion;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = comando;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usuario", parametro);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usuarios = new Usuario(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(0), EEstado.libre, reader.GetInt32(5));
            }

            conexion.Close();


            return usuarios;
        }


        [TestMethod]
        public void GuardarUsuarios_Success()
        {
            Usuario usuario = new Usuario("usuarioPrueba", "test", "usuarioTest", "123", 1, EEstado.libre, 0);
            ConexionBdUsuarios conexion = new();
            Usuario usuarioBD;

            conexion.GuardarUsuarios(usuario, "123");
            usuarioBD = ObtenerUsuario(@"SELECT * FROM usuario_test WHERE Usuario= @usuario", usuario.User);

            Assert.IsNotNull(usuarioBD);
            Assert.IsTrue(usuarioBD.User == usuario.User);

            BorrarUsuario(@"DELETE FROM usuario_test WHERE Usuario= @parameter", usuario.User);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GuardarUsuarios_Fail()
        {
            Usuario usuario = null;
            ConexionBdUsuarios conexion = new();

            conexion.GuardarUsuarios(usuario, "123");
        }

        [TestMethod]
        public void ObtenerTop_Success()
        {
            List<Usuario> usuarios;
            ConexionBdUsuarios conexion = new();

            usuarios = conexion.ObtenerTop();

            Assert.IsNotNull(usuarios);
            Assert.IsTrue(usuarios.Count <= 5);
        }
    }
}
