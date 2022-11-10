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
        Dado dado;
        public event Action EventAction;


        public Partida(List<Jugador> jugadores, string ganador, int cantidad, DateTime date, int id) : this(ganador, cantidad, date, id)
        {
            this.jugadores = jugadores;
           dado = new Dado();
        }
        public Partida(string ganador, int cantidad, DateTime date, int id)
        {
            this.ganador = ganador;
            cantidadJugadores = cantidad;
            this.id = id;
            this.date = date;
            dado = new Dado();
        }


        public int Id
        {
            get { return id; }
        }

        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        public int CantidadJugadores { get => cantidadJugadores; set => cantidadJugadores = value; }

        public DateTime Date
        {
            get { return date; }
        }


        public void TirarDados(int discriminador, int[] tirada)
        {
            Random rnd = new Random();
            if (tirada is not null && tirada.Length!=0)
            {
                for (int i = 0; i < 5; i++)
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
            else
            {
                throw new ArgumentNullException();
            }
        }
            

        public static int GuardarNumero(int[] aux)
        {
            int maximo = -1;
            int retorno = 0;
            Dado dado = new Dado();
            if(aux != null && aux.Length!=0)
            {
                foreach(int cara in dado.Caras)
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

            }else
            {
                throw new ArgumentNullException();
            }
            return retorno;
        }

        public void EncontrarGanador()
        {
            EventAction();
            int puntajeMaximo = 0;
            foreach (Jugador jugador in Jugadores)
            {
                if (jugador.Puntaje > puntajeMaximo)
                {
                    puntajeMaximo = jugador.Puntaje;
                    Ganador = jugador.Usuario.Nombre;
                }
                else if (jugador.Puntaje == puntajeMaximo)
                {
                    Ganador = "Empate";
                }
            }
            foreach(Jugador jugador in jugadores)
            {
                if(jugador.Puntaje== puntajeMaximo && Ganador!="Empate")
                {
                    jugador.Usuario.PartiasGanadas++;
                    ConexionBdUsuarios conexion = new ConexionBdUsuarios();
                    conexion.ActualizarPartidasGanadas(jugador.Usuario);
                }
            }
        }
    }
}
