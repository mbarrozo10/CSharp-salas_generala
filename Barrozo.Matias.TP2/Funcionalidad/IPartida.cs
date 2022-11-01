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
        public void DevolverTiradas(DTiradas delegado, int[] dadosEnMesa);

        public void ConseguirUltimoId(int id);

        public void Informacion(Partida partidaActual, string tirada, int turnosJugados, int indice);

        public void ActualizarDatagrid(Partida partidaActual);

        public void FinalizarPartida(string Ganador);

    }
}
