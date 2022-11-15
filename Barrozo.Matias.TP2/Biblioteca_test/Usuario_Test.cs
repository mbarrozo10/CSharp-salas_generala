using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad_test
{
    [TestClass]
    public class Usuario_Test
    {
        [DataRow("pepe","pepe")]
        [DataRow("Pepe","pepe")]
        [DataRow("pePe","pepe")]
        [DataRow("PEPE","pepe")]
        [DataRow("pEPe","pepe")]
        [TestMethod]
        public void ComprobarInicio_Success(string user, string contraseña)
        {
            Usuario usuario = new Usuario(user, contraseña);

            bool retorno=usuario.ComprobarInicio();

            Assert.IsTrue(retorno);
        }

        [DataRow("pe4pe", "pep2e")]
        [DataRow("Pepe", "pep3e")]
        [DataRow("pePe", "p5epe")]
        [DataRow("PEPE", "p1epe")]
        [DataRow("pEPe", "pepe2")]
        [TestMethod]
        public void ComprobarInicio_Fail(string user, string contraseña)
        {
            Usuario usuario = new Usuario(user, contraseña);

            bool retorno = usuario.ComprobarInicio();

            Assert.IsFalse(retorno);
        }
    }
}
