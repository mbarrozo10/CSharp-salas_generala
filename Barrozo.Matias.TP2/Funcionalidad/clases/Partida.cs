using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad.clases
{
    public class Partida
    {
        int id;
        DateTime date;
        List<Jugador> jugadores;
        string ganador;
        int cantidadJugadores;
        Dados dado;


        public Partida(List<Jugador> jugadores, string ganador, int cantidad, DateTime date, int id) : this(ganador, cantidad, date, id)
        {
            this.jugadores = jugadores;
            dado = new Dados();
        }
        public Partida(string ganador, int cantidad, DateTime date, int id)
        {
            this.ganador = ganador;
            cantidadJugadores = cantidad;
            this.id = id;
            this.date = date;
        }


        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        public int CantidadJugadores { get => cantidadJugadores; set => cantidadJugadores = value; }

        public int Id
        {
            get { return id; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public int[] TirarDados(int cantidad)
        {
            int[] tirada = new int[cantidad];
            Random rnd = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                tirada[i] = dado.Caras[rnd.Next(1, 6)];
            }

            return tirada;
        }

        
    }
}
