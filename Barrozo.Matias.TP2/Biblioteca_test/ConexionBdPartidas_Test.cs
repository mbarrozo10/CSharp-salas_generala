using Funcionalidad.clases;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad_test
{
    [TestClass]
    public class ConexionBdPartidas_Test
    {
        public void BorrarPartidaTest(string comando, string parametro)
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

            conexion.Close();

        }

        public Partida ObtenerPartidaTest(string comando, string parametro)
        {
            Partida partida = null;
            SqlConnection conexion = new SqlConnection(@"Server = localhost ; Database = generalaDb ; Trusted_Connection=True; Encrypt= False ");
            SqlCommand cmd = conexion.CreateCommand();
            conexion.Open();

            cmd.Connection = conexion;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = comando;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@parameter", parametro);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                partida = new Partida(reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetInt32(0), 0, reader.GetString(4));
            }

            conexion.Close();


            return partida;
        }

        [TestMethod]
        public void GuardarPartida_Success()
        {
            ConexionBdPartidas conexion = new ConexionBdPartidas();
            Partida partida = new Partida("GanadorTest", 0, DateTime.Now, 0, 0, "");
            partida.Jugadores = new List<Jugador>();
            partida.Jugadores.Add(new Jugador(new Usuario("", "")));
            Partida partidaBD;

            conexion.GuardarPartida(partida);
            partidaBD = ObtenerPartidaTest(@"SELECT * FROM partidas_test WHERE Ganador=@parameter", partida.Ganador);

            Assert.IsNotNull(partidaBD);
            Assert.AreEqual(partida.Ganador, partidaBD.Ganador);

            BorrarPartidaTest(@"DELETE FROM partidas_test WHERE Ganador= @parameter",partida.Ganador);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GuardarPartida_Fail()
        {
            ConexionBdPartidas conexion = new ConexionBdPartidas();
            Partida partida= null;

            conexion.GuardarPartida(partida);
        }

        [TestMethod]
        public void ObtenerDatosPartidaBag_Success()
        {
            ConcurrentBag<Partida> partidas;
            ConexionBdPartidas conexion = new();

            partidas = conexion.ObtenerDatosPartidaBag();

            Assert.IsNotNull(partidas);
            Assert.IsTrue(!partidas.IsEmpty);
        }

        [TestMethod]
        public void ObtenerUltimoId_Success()
        {
            ConexionBdPartidas partidas = new();
            int ultimoId;

            ultimoId = partidas.ObtenerUltimoId();

            Assert.IsTrue(ultimoId != 0);
            
        }

        [TestMethod]
        public void ConseguirEstadisticasDePartidas_Success()
        {
            ConexionBdPartidas conexion = new();
            string cantidad;

            cantidad = conexion.ConseguirEstadisticasDePartidas(@"SELECT COUNT(Id) FROM partidas_test WHERE Estado= 'Finalizada'");

            Assert.IsNotNull(cantidad);
            Assert.IsTrue(cantidad != "0");
        }

        [DataRow("")]
        [DataRow(null)]
        [ExpectedException(typeof(System.InvalidOperationException))]
        [TestMethod]
        public void ConseguirEstadisticasDePartidas_Fail(string comando)
        {
            ConexionBdPartidas conexion = new();
            string cantidad;

            cantidad = conexion.ConseguirEstadisticasDePartidas(comando);

        }

    }
}
