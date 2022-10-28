using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public interface IMostradorUsuarios
    {
        public void MostrarDatos(List<Usuario> usuarios);
    }
}
