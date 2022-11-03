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

        //valores de menuPrincipal
        List<Usuario> usuarios;

        //public delegate string DGanador();
        //public event DGanador EventEncontrarGanador;
        //Menu Principal
        public void DevolverPartidas<U>(U obj) where U : IMenu
        {
            ConexionBd conexionBd = new ConexionBd();
            //obj.MostrarDatos(conexionBd.ObtenerDatosPartida());
            obj.MostrarDatosPartidas(conexionBd.ObtenerDatosPartidaBag());
        }

        public void ConseguirUsuarios()
        {
            ConexionBd conexionBd = new ConexionBd();
            usuarios = conexionBd.ObtenerUsuarios();
        }

        public void DevolverUsuarios<U>(U obj) where U : IMenu
        {
            
            obj.MostrarDatosUsuarios(usuarios);
        }

        public Task<bool> AgregarJugador<U>(List<Jugador> jugadoresPartida, int indice, U obj) where U : IMenu
        {
            bool encontroError = false;
            if (usuarios[indice].Estado== EEstado.libre)
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


            return obj.AgregarUsuario();
        }
        //Partida
        public void Revisar <U> (U obj, Jugador jugador) where U : IPartida
        {
            obj.DevolverTiradas(jugador.del,dadosEnMesa);
        }
        
        public void ConseguirUltimoId <U> (U obj) where U : IPartida
        {
            ConexionBd conexion = new ConexionBd();
            obj.ConseguirUltimoId(conexion.ObtenerUltimoId());
        }

        // cambiar que retorne partida
        public void IniciarPartida<U>(List<Jugador> jugadores,int ultimoId, int turnos) where U : IPartida
        {
            ConexionBd conexion = new ConexionBd();
            partidaActual = new Partida(jugadores, "", jugadores.Count, DateTime.Now, conexion.ObtenerUltimoId());
            turnosMaximos = turnos;

        }

        public void TirarDados<U>(U obj)where U : IPartida
        {
            string retorno;
            //obj.Informacion(partidaActual);
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


            obj.Informacion(partidaActual,retorno, turnosJugados, indice, dadosEnMesa);
            // revisar en futuro
            Revisar(obj, partidaActual.Jugadores[indice]);

            //bitacora += lblTurnoJugador.Text + lbl_Dados.Text + "\n";

            if (partidaActual.Jugadores[indice].TerminoTurno)
            {
                partidaActual.Jugadores[indice].AsignarANumeros(dadosEnMesa);
                partidaActual.Jugadores[indice].TerminoTurno = false;

                //partidaActual.Jugadores[indice].TurnosJugados = 1;
                CambiarJugador(obj);
            }
            obj.ActualizarDatagrid(partidaActual);
        }

        void CambiarJugador<U>(U obj)where U : IPartida
        {
            //obj.Informacion(partidaActual);

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
                partidaActual.Jugadores.ForEach((x) => partidaActual.EventAction += x.SumarPuntaje);
                obj.ActualizarDatagrid(partidaActual);

                partidaActual.EncontrarGanador();

                obj.FinalizarPartida(partidaActual.Ganador);

            }

        }


        public void GuardarPartida()
        {
            ConexionBd conexion = new ConexionBd();
            conexion.GuardarPartida(partidaActual);
        }

        //Login

        public void ComprobarLogin<U> (Usuario usuario, U obj) where U : ILogin
        {
            obj.ComprobarInicio(usuario.ComprobarInicio());
        }

     

       
    }
    
   
}
