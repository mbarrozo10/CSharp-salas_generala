using Funcionalidad.clases;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public class PresentadorPrincipal
    {
        IMenu obj;
        List<Usuario> usuarios;
        List<Jugador> jugadoresPartida;
        ConcurrentBag<Partida> listaPartidas;
        Estadisticas estadisticas;
        static ConexionBdUsuarios conexionBdUsuarios;
        static ConexionBdPartidas conexionBdPartidas;
        List<CancellationTokenSource> listaDeCancelaciones;
        List<PresentadorPartida> listaDePresentadores = new List<PresentadorPartida>();
        List<Partida> partidasActivas = new List<Partida>();


        static PresentadorPrincipal()
        {
            conexionBdUsuarios = new ConexionBdUsuarios();
            conexionBdPartidas = new ConexionBdPartidas();
            
        }

        public PresentadorPrincipal(IMenu obj)
        {
            this.obj = obj;
            listaDeCancelaciones = new();
            estadisticas = new Estadisticas(0, new List<Usuario>(), 0, 0, 0);
            jugadoresPartida = new List<Jugador>();
        }

        public void DevolverPartidas()
        {

            listaPartidas = conexionBdPartidas.ObtenerDatosPartidaBag();
            obj.MostrarDatosPartidas(listaPartidas);
        }

        public void ConseguirUsuarios()
        {
            usuarios = conexionBdUsuarios.ObtenerUsuarios();
        }

        public void DevolverUsuarios() 
        {
            obj.MostrarDatosUsuarios(usuarios);
        }

   
        public bool AgregarJugador(int indice)
        {
            bool encontroError = false;
            if (usuarios[indice].Estado == EEstado.libre)
            {
                Jugador jugadorAux = new Jugador(usuarios[indice]);
                if (jugadoresPartida.Count == 0)
                {
                    usuarios[indice].Estado = EEstado.jugando;
                    jugadoresPartida.Add(jugadorAux);
                }
                else
                {
                    foreach (Jugador jugador in jugadoresPartida)
                    {
                        if (jugador.Usuario == usuarios[indice])
                        {
                            encontroError = true;
                            break;
                        }
                        else
                        {
                            usuarios[indice].Estado = EEstado.jugando;
                            jugadoresPartida.Add(jugadorAux);
                            break;
                        }
                    }
                }
                if (encontroError)
                {
                    throw new Exception("Ya Esta agregado este jugador");
                }

            }
            else
            {
                throw new Exception("Ya Esta agregado este jugador");
            }


            return obj.AgregarUsuario(jugadoresPartida);

        }

        public void CargarEstadisticas()         
        {
            estadisticas.CantidadPartidasJugadas = listaPartidas.Count();
            obj.MostrarEstadisticas(estadisticas.CantidadPartidasJugadas.ToString(), conexionBdPartidas.ConseguirEstadisticasDePartidas("SELECT COUNT(Ganador) FROM partidas_test WHERE Ganador= 'empate'"),
            conexionBdPartidas.ConseguirEstadisticasDePartidas("SELECT COUNT(id) FROM partidas_test WHERE Estado= 'Cancelada'"),
            conexionBdPartidas.ConseguirEstadisticasDePartidas("SELECT COUNT(id) FROM partidas_test WHERE Estado= 'Finalizada'"), conexionBdUsuarios.ObtenerTop());
        }
    
        public List<PresentadorPartida> ListaDePresentadores { get => listaDePresentadores; set => listaDePresentadores = value; }
        public List<Partida> PartidasActivas { get => partidasActivas; set => partidasActivas = value; }

        public async void AgregarPartida(int turnosAJugar)
        {
            List<Jugador> jugadoresParaPartida = new List<Jugador>();
            jugadoresPartida.ForEach((x) => jugadoresParaPartida.Add(x));
            jugadoresPartida.Clear();
            PresentadorPartida presentadortest = new();
            listaDePresentadores.Add(presentadortest);
            listaDeCancelaciones.Add(new CancellationTokenSource());
            
            partidasActivas.Add(presentadortest.IniciarPartida(jugadoresParaPartida, turnosAJugar, listaDeCancelaciones.Last().Token));
           
            await presentadortest.PartidaActual.EmpezarTarea();
        }

        public void CancelarPartida(int indice)
        {
            listaDePresentadores[indice].CancelarPartida();
            listaDeCancelaciones[indice].Cancel();
        }
    }
}
