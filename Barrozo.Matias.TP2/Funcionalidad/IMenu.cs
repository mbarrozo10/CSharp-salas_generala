using Funcionalidad.clases;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public interface IMenu
    {
        public void MostrarDatosUsuarios(List<Usuario> usuarios);
        public void MostrarDatosPartidas(ConcurrentBag<Partida> partidas);

        public async Task<bool> AgregarUsuario()
        {
            return true;
        }
    }
}
