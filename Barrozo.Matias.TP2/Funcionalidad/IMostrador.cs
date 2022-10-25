using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public interface IMostrador
    {
        public void MostrarDatos(List<Partida> partidas);
        public void MostrarDatos(List<Jugador> jugadors);
    }
}
