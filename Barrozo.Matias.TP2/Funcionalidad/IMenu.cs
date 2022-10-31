using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public interface IMenu
    {
        public void MostrarDatos<T>(List<T> usuarios);

        public bool AgregarUsuario();
    }
}
