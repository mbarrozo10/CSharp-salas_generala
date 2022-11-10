using Funcionalidad;
using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad_test
{
    [TestClass]
    public class Partida_Test
    {
        [DataRow (new int[] {0,0,0,0,0}, -1)]
        [DataRow (new int[] {1,1,1,1,1}, 1)]

        [TestMethod]
        public void TirarDados_Success(int[] tirada, int discriminador)
        {
            Partida partidaTest = new Partida("", 2, DateTime.Now, 0);

            partidaTest.TirarDados(discriminador, tirada);

            Assert.IsNotNull(tirada);
        }

        [DataRow(new int[] {}, -1)]
        [DataRow(null, -1)]
        [ExpectedException (typeof (ArgumentNullException))]
        [TestMethod]
        public void TirarDados_Fail(int[] tirada, int discriminador)
        {
            Partida partidaTest = new Partida("", 2, DateTime.Now, 0);

            partidaTest.TirarDados(discriminador, tirada);

            //Assert.ex;
        }

        [DataRow (new int[] {1,1,1,2,2 },1)]
        [DataRow (new int[] {1,1,2,2,2 },2)]
        [DataRow (new int[] {3,3,3,2,2 },3)]
        [DataRow (new int[] {1,5,5,5,5 },5)]
        [TestMethod]
        public void GuardarNumero_Success(int[] tirada, int retornoSuccess)
        {
            int retorno;

            retorno= Partida.GuardarNumero(tirada);

            Assert.AreEqual(retornoSuccess, retorno);

        }

        [DataRow(null, 1)]
        [DataRow(new int[] {}, 2)]
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void GuardarNumero_Fail(int[] tirada, int retornoSuccess)
        {
            int retorno;

            retorno = Partida.GuardarNumero(tirada);

           // Assert.AreEqual(retornoSuccess, retorno);

        }

        [DataRow(20,10)]
        [DataRow(50,10)]
        [DataRow(60,10)]
        [DataRow(10,20)]
        [TestMethod]
        public void EncontrarGanador_Success(int puntajeGanador, int puntajePerdedor)
        {
            Jugador ganador = new Jugador(new Usuario("pepe", "",""));
            Jugador perdedor = new Jugador(new Usuario("pepe2", "",""));
            List<Jugador> lista = new();
            lista.Add(ganador);
            lista.Add(perdedor);
            PresentadorGenerico presentador = new();
            Partida partida = new Partida(lista, "", 0, DateTime.Now, 10); 


            ganador.Puntaje = puntajeGanador;
            perdedor.Puntaje = puntajePerdedor;
            partida.EncontrarGanador();

            Assert.IsTrue(partida.Ganador == ganador.Usuario.Nombre);
        }
    }
}
