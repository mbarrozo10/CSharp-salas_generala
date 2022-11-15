using BibliotecaDeClases;
using Funcionalidad.clases;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Funcionalidad
{
    public class PresentadorGenerico
    {

        static ConexionBdUsuarios conexionBdUsuarios;
        static ConexionBdPartidas conexionBdPartidas;

        static PresentadorGenerico(){
            conexionBdUsuarios = new ConexionBdUsuarios();
            conexionBdPartidas = new ConexionBdPartidas();
        }
        //valores partida

        Partida partidaActual;
        string bitacora = "";


        //valores de menuPrincipal
        List<Usuario> usuarios;
        List<Jugador> jugadoresPartida = new List<Jugador>();
        List<Task> tareasTest = new List<Task>();
        ConcurrentBag<Partida> listaPartidas;
      



        //Menu Principal
        public void DevolverPartidas<U>(U obj) where U : IMenu
        {
            
            listaPartidas = conexionBdPartidas.ObtenerDatosPartidaBag();
            obj.MostrarDatosPartidas(listaPartidas);
        }

        public void ConseguirUsuarios()
        {
            usuarios = conexionBdUsuarios.ObtenerUsuarios();
        }

        public void DevolverUsuarios<U>(U obj) where U : IMenu
        { 
            obj.MostrarDatosUsuarios(usuarios);
        }
        
        public void DevolverTareas<U>(U obj) where U : IMenu
        { 
            obj.MostrarDatosTareas(tareasTest);
        }

        public Task<bool> AgregarJugador<U>(int indice, U obj) where U : IMenu
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


            return obj.AgregarUsuario(jugadoresPartida, tareasTest);

        }

        public async Task EmpezarTarea()
        {
             tareasTest.Last().Start();
        }


        //Partida
      
        public void IniciarPartida<U>(List<Jugador> jugadores, int turnos) where U : IPartida
        {
            partidaActual = new Partida(jugadores, "", jugadores.Count, DateTime.Now, conexionBdPartidas.ObtenerUltimoId()+1,turnos);
            partidaActual.Jugadores.ForEach((x) => partidaActual.EventAction += x.SumarPuntaje);
        }

        public void TirarDados<U>(U obj)where U : IPartida
        {

            string resumenPartida = partidaActual.Jugar();

            obj.Informacion(partidaActual);
            
            if (partidaActual.VerificarTurno())
            {
                obj.FinalizarPartida(partidaActual.Ganador);
            }

            bitacora += partidaActual.Jugadores[partidaActual.indice].Usuario.Nombre + " " + resumenPartida + "\n";

            obj.ActualizarDatagrid(partidaActual);
            
        }


        public void GuardarResumenPartida()
        {
            string archivo = "BitacoraDePartida" + partidaActual.Id;
            Archivo.Escribir(bitacora, archivo);
        }
        public void GuardarPartida<U>() where U : IPartida
        {
            conexionBdPartidas.GuardarPartida(partidaActual);
        }

        //Login

        public void ComprobarLogin<U> (Usuario usuario, U obj) where U : ILogin
        {
            obj.ComprobarInicio(usuario.ComprobarInicio());
        }

        //Alta Usuarios

        public void AgregarUsuario(string nombre, string apellido, string user, string contraseña)
        {
            Usuario usuario = new Usuario(nombre, apellido, user);
            conexionBdUsuarios.GuardarUsuarios(usuario, contraseña);
        }

        //public void AgregarTarea()
        //{
        //    tareasTest.Add(new Task(() =>
        //    {
        //        List<Jugador> test = new List<Jugador>();
        //        jugadoresPartida.ForEach((x) => test.Add(x));
        //        jugadoresPartida.Clear();
        //        frm_Partida partida = new frm_Partida(test, 1 + turnosAJugar * (int)(nud_CantidadJugadores.Value), config);
        //        partida.ShowDialog();
        //        test.ForEach((x) => x.Usuario.Estado = EEstado.libre);

        //    }));
        //}
    }
    
   
}
