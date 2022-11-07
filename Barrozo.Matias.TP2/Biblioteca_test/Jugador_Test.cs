using Funcionalidad.clases;

namespace Biblioteca_test
{
    [TestClass]
    public class Jugador_Test
    {
        [DataRow(new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(new int[] { 2, 3, 4, 5, 6 })]
        [TestMethod]
        public void CheckEscalera_Success(int [] aux)
        {
            int[] tiradaOk = { 5, 4, 3, 2, 1 };
            Jugador jugadorTest = new Jugador(new Usuario("pepe","pepe"));
            Jugador jugadorSuccess = new Jugador(new Usuario("pepe", "pepe"));

            jugadorSuccess.RevisarEscalera(tiradaOk);
            jugadorTest.RevisarEscalera(aux);

            Assert.AreEqual(jugadorSuccess.Escalera, jugadorTest.Escalera);
        }
        
        [DataRow(new int[] {4,2,3,4,5})]
        [DataRow(new int[] {4,2,4,3,7})]
        [DataRow(new int[] { 1, 3, 4, 5, 6 })]

        [TestMethod]
        public void CheckEscalera_Fail(int[] aux)
        {
            int[] tiradaOk = { 4, 4, 5, 2, 1 };
            Jugador jugadorTest = new Jugador(new Usuario("pepe", "pepe"));
            Jugador jugadorSuccess = new Jugador(new Usuario("pepe", "pepe"));

            jugadorSuccess.RevisarEscalera(tiradaOk);
            jugadorTest.RevisarEscalera(aux);

            Assert.AreEqual(jugadorSuccess.Escalera, jugadorTest.Escalera);
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
            int[] tiradaOk = { 5, 5, 5, 5, 5 };
            Jugador jugadorTest = new Jugador(new Usuario("pepe", "pepe"));
            Jugador jugadorSuccess = new Jugador(new Usuario("pepe", "pepe"));

            jugadorSuccess.RevisarGenerala(tiradaOk);
            jugadorTest.RevisarGenerala(aux);

            Assert.AreEqual(jugadorSuccess.Generala, jugadorTest.Generala);
        }
        
        [DataRow(new int[] {4,2,3,4,5})]
        [DataRow(new int[] {4,2,4,3,7})]
        [DataRow(new int[] {2,2,4,3,7})]
        [TestMethod]
        public void CheckGenerala_Fail(int[] aux)
        {
            int[] tiradaOk = { 4, 4, 5, 2, 1 };
            Jugador jugadorTest = new Jugador(new Usuario("pepe", "pepe"));
            Jugador jugadorSuccess = new Jugador(new Usuario("pepe", "pepe"));

            jugadorSuccess.RevisarGenerala(tiradaOk);
            jugadorTest.RevisarGenerala(aux);

            Assert.AreEqual(jugadorSuccess.Generala, jugadorTest.Generala);
        }
        
        [DataRow(new int[] {4,2,3,4,5})]
        [DataRow(new int[] {4,2,4,3,6})]
        [DataRow(new int[] {2,2,4,3,6})]
        [DataRow(new int[] {2,2,4,3,6})]
        [TestMethod]
        public void CheckPoker_Fail(int[] aux)
        {
            int[] tiradaOk = { 1, 1, 4, 2, 2 };
            Jugador jugadorTest = new Jugador(new Usuario("pepe", "pepe"));
            Jugador jugadorSuccess = new Jugador(new Usuario("pepe", "pepe"));

            jugadorSuccess.RevisarPoker(tiradaOk);
            jugadorTest.RevisarPoker(aux);

            Assert.AreEqual(jugadorSuccess.Poker, jugadorTest.Poker);
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
            int[] tiradaOk = { 4, 4, 4, 4, 1 };
            Jugador jugadorTest = new Jugador(new Usuario("pepe", "pepe"));
            Jugador jugadorSuccess = new Jugador(new Usuario("pepe", "pepe"));

            jugadorSuccess.RevisarPoker(tiradaOk);
            jugadorTest.RevisarPoker(aux);

            Assert.AreEqual(jugadorSuccess.Poker, jugadorTest.Poker);
        }


        [DataRow(new int[] { 4, 2, 3, 4, 5 })]
        [DataRow(new int[] { 4, 2, 4, 3, 6 })]
        [DataRow(new int[] { 2, 2, 4, 3, 6 })]
        [DataRow(new int[] { 2, 2, 4, 3, 6 })]
        [DataRow(new int[] { 1, 1, 1, 1, 1 })]
        [TestMethod]
        public void CheckFull_Fail(int[] aux)
        {
            int[] tiradaOk = { 4, 4, 4, 4, 4 };
            Jugador jugadorTest = new Jugador(new Usuario("pepe", "pepe"));
            Jugador jugadorSuccess = new Jugador(new Usuario("pepe", "pepe"));

            jugadorSuccess.RevisarFull(tiradaOk);
            jugadorTest.RevisarFull(aux);

            Assert.AreEqual(jugadorSuccess.Full, jugadorTest.Full);
        }

        [DataRow(new int[] { 4, 4, 4, 5, 5 })]
        [DataRow(new int[] { 5, 5, 5, 2, 2 })]
        [DataRow(new int[] { 5, 2, 5, 5, 2 })]
        [DataRow(new int[] {2,4 ,2 , 4, 2 })]
        [TestMethod]
        public void CheckFull_Succes(int[] aux)
        {
            int[] tiradaOk = { 4, 4, 4, 3, 3 };
            Jugador jugadorTest = new Jugador(new Usuario("pepe", "pepe"));
            Jugador jugadorSuccess = new Jugador(new Usuario("pepe", "pepe"));

            jugadorSuccess.RevisarFull(tiradaOk);
            jugadorTest.RevisarFull(aux);

            Assert.AreEqual(jugadorSuccess.Full, jugadorTest.Full);
        }
    }
}