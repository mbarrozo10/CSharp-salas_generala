using Funcionalidad;

namespace Biblioteca_test
{
    [TestClass]
    public class Partida_test
    {
        [DataRow(new int[] {1,2,3,4,5})]
        [DataRow(new int[] {2,3,4,5,6})]
        [TestMethod]
        public void CheckEscalera_Success(int [] aux)
        {
            bool restultadoEsperado = true;

            bool resultado = Partida.CheckEscalera(aux);

            Assert.AreEqual(resultado, restultadoEsperado);
        }
        
        [DataRow(new int[] {4,2,3,4,5})]
        [DataRow(new int[] {4,2,4,3,7})]
        [TestMethod]
        public void CheckEscalera_Fail(int[] aux)
        {
            bool restultadoEsperado = false;

            bool resultado = Partida.CheckEscalera(aux);

            Assert.AreEqual(resultado, restultadoEsperado);
        }

        [DataRow(new int[] { 4, 4, 4, 4, 4 })]
        [DataRow(new int[] { 2, 2, 2, 2, 2 })]
        [DataRow(new int[] { 3, 3, 3, 3, 3 })]
        [DataRow(new int[] { 1, 1, 1, 1, 1 })]
        [DataRow(new int[] { 5, 5, 5, 5, 5 })]
        [DataRow(new int[] { 6, 6, 6, 6, 6 })]
        [TestMethod]
        public void CheckGenerala_Success(int [] aux)
        {
            bool restultadoEsperado = true;

            bool resultado = Partida.CheckGenerala(aux);

            Assert.AreEqual(resultado, restultadoEsperado);
        }
        
        [DataRow(new int[] {4,2,3,4,5})]
        [DataRow(new int[] {4,2,4,3,7})]
        [DataRow(new int[] {2,2,4,3,7})]
        [TestMethod]
        public void CheckGenerala_Fail(int[] aux)
        {
            bool restultadoEsperado = false;

            bool resultado = Partida.CheckGenerala(aux);

            Assert.AreEqual(resultado, restultadoEsperado);
        }
        
        [DataRow(new int[] {4,2,3,4,5})]
        [DataRow(new int[] {4,2,4,3,6})]
        [DataRow(new int[] {2,2,4,3,6})]
        [DataRow(new int[] {2,2,4,3,6})]
        [DataRow(new int[] {1,1,1,1,1})]
        [TestMethod]
        public void CheckPoker_Fail(int[] aux)
        {
            bool restultadoEsperado = false;

            bool resultado = Partida.CheckPoker(aux);

            Assert.AreEqual(resultado, restultadoEsperado);
        }

        [DataRow(new int[] { 4, 4, 4, 4, 5 })]
        [DataRow(new int[] { 1, 1, 1, 1, 3 })]
        [DataRow(new int[] { 3, 3, 3, 3, 7 })]
        [DataRow(new int[] { 2, 2, 4, 2, 2 })]
        [DataRow(new int[] { 2, 3, 2, 2, 2 })]
        [DataRow(new int[] { 2, 2, 2, 3, 2 })]
        [DataRow(new int[] {2,2,2,1,2})]
        [TestMethod]
        public void CheckPoker_Succes(int[] aux)
        {
            bool restultadoEsperado = true;

            bool resultado = Partida.CheckPoker(aux);

            Assert.AreEqual(resultado, restultadoEsperado);
        }


        [DataRow(new int[] { 4, 2, 3, 4, 5 })]
        [DataRow(new int[] { 4, 2, 4, 3, 6 })]
        [DataRow(new int[] { 2, 2, 4, 3, 6 })]
        [DataRow(new int[] { 2, 2, 4, 3, 6 })]
        [DataRow(new int[] { 1, 1, 1, 1, 1 })]
        [TestMethod]
        public void CheckFull_Fail(int[] aux)
        {
            bool restultadoEsperado = false;

            bool resultado = Partida.CheckFull(aux);

            Assert.AreEqual(resultado, restultadoEsperado);
        }

        [DataRow(new int[] { 4, 4, 4, 5, 5 })]
        [DataRow(new int[] { 5, 5, 5, 2, 2 })]
        [DataRow(new int[] { 5, 2, 5, 5, 2 })]
        [DataRow(new int[] {2,4 ,2 , 4, 2 })]
        [TestMethod]
        public void CheckFull_Succes(int[] aux)
        {
            bool restultadoEsperado = true;

            bool resultado = Partida.CheckFull(aux);

            Assert.AreEqual(resultado, restultadoEsperado);
        }
    }
}