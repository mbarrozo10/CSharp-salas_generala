using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad.clases
{
    public class Jugador
    {
        string nombre;
        int puntaje;
        int generala;
        int dobleGenerala;
        int full;
        int poker;
        int escalera;



        public Jugador(string nombre, int puntaje)
        {
            Nombre = nombre;
            Puntaje = puntaje;
            generala = 0;
            dobleGenerala = 0;
            full = 0;
            poker = 0;
            escalera = 0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public int Generala { get => generala; set => generala = value; }
        public int DobleGenerala { get => dobleGenerala; set => dobleGenerala = value; }
        public int Full { get => full; set => full = value; }
        public int Poker { get => poker; set => poker = value; }
        public int Escalera { get => escalera; set => escalera = value; }
    }
}
