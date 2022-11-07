using BibliotecaDeClases;
using Funcionalidad.clases;
using System;
using System.Collections.Concurrent;
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
        private int turnosJugados = 1;
        string bitacora = "";


        //valores de menuPrincipal
        List<Usuario> usuarios;
        List<Jugador> jugadoresPartida = new List<Jugador>();
        List<Task> tareasTest = new List<Task>();
        ConcurrentBag<Partida> listaPartidas;
      



        //Menu Principal
        public void DevolverPartidas<U>(U obj) where U : IMenu
        {
            ConexionBdPartidas conexionBd = new ConexionBdPartidas();
            //obj.MostrarDatos(conexionBd.ObtenerDatosPartida());
            listaPartidas = conexionBd.ObtenerDatosPartidaBag();
            obj.MostrarDatosPartidas(listaPartidas);
        }

        public void ConseguirUsuarios()
        {
            ConexionBdUsuarios conexionBd = new ConexionBdUsuarios();
            usuarios = conexionBd.ObtenerUsuarios();
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

        public async Task prueba()
        {
            tareasTest.Last().Start();
        }


        //Partida
        public void Revisar <U> (U obj, Jugador jugador) where U : IPartida
        {
            obj.DevolverTiradas(jugador.del,dadosEnMesa);
        }
        
        //public void ConseguirUltimoId <U> (U obj) where U : IPartida
        //{
        //    ConexionBdPartidas conexion = new ConexionBdPartidas();
        //    obj.ConseguirUltimoId(conexion.ObtenerUltimoId());
        //}

        // cambiar que retorne partida
        public void IniciarPartida<U>(List<Jugador> jugadores, int turnos) where U : IPartida
        {
            ConexionBdPartidas conexion = new ConexionBdPartidas();
            partidaActual = new Partida(jugadores, "", jugadores.Count, DateTime.Now, conexion.ObtenerUltimoId()+1);
            turnosMaximos = turnos;

        }

        public void TirarDados<U>(U obj)where U : IPartida
        {
            string retorno;
            //obj.Informacion(partidaActual);
            if (partidaActual.Jugadores[indice].TurnosJugados == 1)
            {
                partidaActual.TirarDados( -1, dadosEnMesa);
            }
            else
            {
                int numeroAGuardar = Partida.GuardarNumero(dadosEnMesa);
                partidaActual.TirarDados( numeroAGuardar, dadosEnMesa);
            }
            retorno = "Tirada :" + dadosEnMesa[0].ToString();
            retorno += "-" + dadosEnMesa[1].ToString();
            retorno += "-" + dadosEnMesa[2].ToString();
            retorno += "-" + dadosEnMesa[3].ToString();
            retorno += "-" + dadosEnMesa[4].ToString();

            bitacora += partidaActual.Jugadores[indice].Usuario.Nombre +" "+ retorno + "\n";

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

        public void GuardarResumenPartida()
        {
            string archivo = "BitacoraDePartida" + partidaActual.Id;
            Archivo.Escribir(bitacora, archivo, @".\Bitacoras");
        }
        public void GuardarPartida<U>() where U : IPartida
        {
            ConexionBdPartidas conexion = new ConexionBdPartidas();
            conexion.GuardarPartida(partidaActual);
        }

        //Login

        public void ComprobarLogin<U> (Usuario usuario, U obj) where U : ILogin
        {
            obj.ComprobarInicio(usuario.ComprobarInicio());
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
