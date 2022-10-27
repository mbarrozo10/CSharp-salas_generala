using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public class PruebaSerializacion
    {
        List<Jugador> jugadores;

        public PruebaSerializacion()
        {
            Jugadores = new List<Jugador>();
        }

        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
    }
}
