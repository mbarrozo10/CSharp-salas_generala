using Microsoft.IdentityModel.Tokens;
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

        public void TirarDados(int cantidad,int discriminador, int[] tirada)
        {
           // int[] tirada = new int[cantidad];
            Random rnd = new Random();
            for (int i = 0; i < cantidad; i++)
            {
               if (tirada[i] != discriminador)
                {
                    tirada[i] = dado.Caras[rnd.Next(0, 6)];
                }
                else
                {
                    tirada[i] = discriminador; 
                }
            }
            Jugador.Ordenar(tirada);
           }

        public int GuardarNumero(int[] aux)
        {
            int maximo = -1;
            int retorno = 0;
            foreach(int cara in this.dado.Caras)
            {
                int contador = 0;
                foreach (int numeroEnArray in aux)
                {
                    if (cara == numeroEnArray)
                    {
                        contador++;
                    }
                }
                if (contador > maximo)
                {
                    maximo = contador;
                    retorno = cara;
                }
            }
            return retorno;
        }
    }
}
