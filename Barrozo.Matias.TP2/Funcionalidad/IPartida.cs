using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Funcionalidad.clases.Jugador;

namespace Funcionalidad
{
    public interface IPartida
    {
        public void DevolverTiradas(DTiradas delegado);

        public void ConseguirUltimoId(int id);

    }
}
