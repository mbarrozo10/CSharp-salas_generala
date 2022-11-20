using BibliotecaDeClases;
using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Funcionalidad
{
    public class PresentadorPartida
    {
        public bool enPantalla=false;
        static ConexionBdPartidas conexionBdPartidas;

        static PresentadorPartida()
        {
            conexionBdPartidas = new ConexionBdPartidas();
        }
        
        Partida? partidaActual;

        public Partida? PartidaActual { get => partidaActual; set => partidaActual = value; }

    
        public Partida IniciarPartida(List<Jugador> jugadores, int turnos, CancellationToken cancel)
        {
            partidaActual = new Partida(cancel,jugadores, "", jugadores.Count, DateTime.Now, conexionBdPartidas.ObtenerUltimoId() + 1, turnos, "Empezada");
            partidaActual.Jugadores.ForEach((x) => partidaActual.EventAction += x.SumarPuntaje);
            return partidaActual;
        }

        public void CancelarPartida()
        {
            partidaActual.Estado = "Cancelada";
            partidaActual.GuardarPartida();
        }

    }
}
