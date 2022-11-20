using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad_test
{
    [TestClass]
    public class Serializador_Test
    {
        [TestMethod]
        public void Serializador_Deserializador_Success()
        {
            Dado dado = new Dado();
            Dado dadoLeido;

            Serializador<Dado>.EscribirJSON(dado,"Dado_Test");
            dadoLeido = Serializador<Dado>.LeerJSON("Dado_Test");

            Assert.AreEqual(dado.Caras.Count, dadoLeido.Caras.Count);
        }

        [DataRow(null)]
        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void Serializador_Fail(string nombre)
        {
            Dado dado=null;

            Serializador<Dado>.EscribirJSON(dado, nombre);
        }

        [DataRow("")]
        [DataRow(null)]
        [DataRow("pepe")]
        [ExpectedException(typeof (FileNotFoundException))]
        [TestMethod]
        public void Deserializador_Fail(string nombre)
        {
            Dado dado;

            dado = Serializador<Dado>.LeerJSON(nombre);
        }
    }
}
