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
    }
}
