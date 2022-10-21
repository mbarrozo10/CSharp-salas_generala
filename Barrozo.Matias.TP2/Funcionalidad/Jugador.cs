using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public class Jugador
    {
        string nombre;
        int puntaje;
        bool generala;
        bool dobleGenerala;
        bool full;
        bool poker;
        bool escalera;

        
        public Jugador(string nombre, int puntaje)
        {
            this.Nombre = nombre;
            this.Puntaje = puntaje;
            generala = false;
            dobleGenerala = false;
            full = false;
            poker = false;
            escalera = false;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public bool Generala { get => generala; set => generala = value; }
        public bool DobleGenerala { get => dobleGenerala; set => dobleGenerala = value; }
        public bool Full { get => full; set => full = value; }
        public bool Poker { get => poker; set => poker = value; }
        public bool Escalera { get => escalera; set => escalera = value; }
    }
}
