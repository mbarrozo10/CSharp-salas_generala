using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public class PresentadorGenerico
    {
        //valores partida
        int[] dadosEnMesa = new int[5];
        int indice = 0;
        Partida partidaActual;
        private int turnosMaximos;
        private int turnosJugados=1;


        //Menu Principal
        public void DevolverPartidas<U>(U obj) where U : IMenu
        {
            obj.MostrarDatos(ConexionBd.ObtenerDatosPartida());
        }

        public void DevolverUsuarios<U>(U obj) where U : IMenu
        {
            obj.MostrarDatos(ConexionBd.ObtenerUsuarios());
        }

        //Partida
        public void Revisar <U> (U obj, Jugador jugador) where U : IPartida
        {
            obj.DevolverTiradas(jugador.del,dadosEnMesa);
        }
        
        public void ConseguirUltimoId <U> (U obj) where U : IPartida
        {
            obj.ConseguirUltimoId(ConexionBd.ObtenerUltimoId());
        }

        public void IniciarPartida<U>(List<Jugador> jugadores,int ultimoId, int turnos) where U : IPartida
        {
            partidaActual = new Partida(jugadores, "", jugadores.Count, DateTime.Now, ultimoId);
            turnosMaximos = turnos;

        }

        public string TirarDados<U>(U obj)where U : IPartida
        {
            string retorno;
            obj.Informacion(partidaActual);
            if (partidaActual.Jugadores[indice].TurnosJugados == 1)
            {
                partidaActual.TirarDados(5, -1, dadosEnMesa);
            }
            else
            {
                int numeroAGuardar = Partida.GuardarNumero(dadosEnMesa);
                partidaActual.TirarDados(5, numeroAGuardar, dadosEnMesa);
            }
            retorno = "Tirada :" + dadosEnMesa[0].ToString();
            retorno += "-" + dadosEnMesa[1].ToString();
            retorno += "-" + dadosEnMesa[2].ToString();
            retorno += "-" + dadosEnMesa[3].ToString();
            retorno += "-" + dadosEnMesa[4].ToString();


            // revisar en futuro
            this.Revisar(obj, partidaActual.Jugadores[indice]);

            //bitacora += lblTurnoJugador.Text + lbl_Dados.Text + "\n";

            if (partidaActual.Jugadores[indice].TerminoTurno)
            {
                partidaActual.Jugadores[indice].AsignarANumeros(dadosEnMesa);
                partidaActual.Jugadores[indice].TerminoTurno = false;

                //partidaActual.Jugadores[indice].TurnosJugados = 1;
                CambiarJugador(obj);
            }
            obj.Informacion(partidaActual);
            obj.ActualizarDatagrid(partidaActual,turnosJugados,indice);
            return retorno;
        }

        void CambiarJugador<U>(U obj)where U : IPartida
        {
            dadosEnMesa = new int[5];
            if (indice != partidaActual.Jugadores.Count - 1)
            {
                indice++;
            }
            else
            {
                indice = 0;
            }
            turnosJugados++;
            if (turnosJugados == turnosMaximos)
            {
                obj.ActualizarDatagrid(partidaActual, turnosJugados, indice);
                //tmrTiempoPartida.Stop();

                partidaActual.Ganador = EncontrarGanador();
                
                obj.FinalizarPartida(partidaActual.Ganador);

            }

        }

        string EncontrarGanador()
        {
            string ganador = "Empate";
            int puntajeMaximo = 0;
            foreach (Jugador jugador in partidaActual.Jugadores)
            {
                if (jugador.Puntaje > puntajeMaximo)
                {
                    puntajeMaximo = jugador.Puntaje;
                    ganador = jugador.Usuario.Nombre;
                }
                else if (jugador.Puntaje == puntajeMaximo)
                {
                    ganador = "Empate";
                }
            }

            return ganador;
        }

        public void GuardarPartida()
        {
            ConexionBd.GuardarPartida(partidaActual);
        }

        //Login

        public void ComprobarLogin<U> (Usuario usuario, U obj) where U : ILogin
        {
            obj.ComprobarInicio(usuario.ComprobarInicio());
        }

        public bool AgregarJugador<U>(List<Jugador> jugadoresPartida, Usuario usuario, U obj) where U: IMenu
        {
            bool encontroError = false;
            Jugador jugadorAux = new Jugador(usuario);
            //if (!jugadoresPartida.Contains(jugadorAux))
            //{
            //    jugadoresPartida.Add(jugadorAux);
            //}
            //else
            //{
            //    throw new Exception("Ya Esta agregado este jugador");
            //}
            if (jugadoresPartida.Count == 0)
            {
                jugadoresPartida.Add(jugadorAux);

            }
            else
            {
                foreach (Jugador jugador in jugadoresPartida)
                {
                    if (jugador.Usuario == usuario)
                    {
                        encontroError = true;
                        break;
                    }
                    else
                    {
                        jugadoresPartida.Add(jugadorAux);
                        break;
                    }
                }
            }
            if (encontroError)
            {
                throw new Exception("Ya Esta agregado este jugador");
            }

            return obj.AgregarUsuario();
        }
    }
    
   
}
