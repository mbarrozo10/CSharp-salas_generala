using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public interface IMostradorPartidas
    {
        public void MostrarDatos(List<Partida> partidas);
    }
}
