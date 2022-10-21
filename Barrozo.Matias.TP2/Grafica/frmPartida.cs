using Funcionalidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafica
{
    public partial class frmPartida : Form
    {
        DateTime hora = new DateTime(2022, 1, 2, 0, 0, 0);
        List<Jugador> jugadoresActivos= new List<Jugador>();
        Partida partidaActual;
        int indice=0;
        int tiradasJugador = 0;
        int turnosJugados = 0;
        public frmPartida()
        {
            InitializeComponent();
        }
        
        public frmPartida(List<Jugador> jugador): this()
        {
            jugadoresActivos=jugador;
            tmrTiempoPartida.Start();
            partidaActual = new Partida(jugador, "",jugador.Count, DateTime.Now,1);
        }

        private void frmPartida_Load(object sender, EventArgs e)
        {
            Informacion();
           }

        private void Informacion()
        {
            lbljugador1.Text = jugadoresActivos[0].Nombre + "  Puntaje: " + jugadoresActivos[0].Puntaje;
            lbljugador2.Text = jugadoresActivos[1].Nombre + "  Puntaje: " + jugadoresActivos[1].Puntaje;
        }

        private void tmrTiempoPartida_Tick(object sender, EventArgs e)
        {
            Jugador jugadorActual = partidaActual.Jugadores[indice];
            lblTurnoJugador.Text = jugadorActual.Nombre;
            hora = hora.AddSeconds(1);
            lblTiempoPartida.Text = hora.ToString("mm:ss");
            int horaInt = int.Parse(hora.ToString("ss"));
            if (horaInt % 2 == 0)
            {
                int[] aux = partidaActual.TirarDados(5);
               lbldados.Text = aux[0].ToString();
               lbldados.Text += "-"+ aux[1].ToString();
               lbldados.Text += "-" + aux[2].ToString();
               lbldados.Text += "-" + aux[3].ToString();
               lbldados.Text += "-" + aux[4].ToString();

                if (Partida.CheckGenerala(aux) && !(jugadorActual.Generala && jugadorActual.DobleGenerala))
                {
                    partidaActual.Jugadores[indice].Generala = true;
                    CambiarJugador(60);
                }
                else if(Partida.CheckEscalera(aux) && !jugadorActual.Escalera)
                {
                    partidaActual.Jugadores[indice].Escalera = true;
                    CambiarJugador(20);
                }
                else if(Partida.CheckFull(aux) && !jugadorActual.Full)
                {
                    partidaActual.Jugadores[indice].Full = true;
                    CambiarJugador(30);
                }
                else if(Partida.CheckPoker(aux) && !jugadorActual.Poker)
                {
                    partidaActual.Jugadores[indice].Poker = true;
                    CambiarJugador(40);
                }
              
                tiradasJugador++;
                

                if (tiradasJugador == 3)
                {
                    tiradasJugador = 0;
                    CambiarJugador(0);
                }
                ActualizarDatagrid();
            }
        }

        private void CambiarJugador(int puntaje)
        {
            partidaActual.Jugadores[indice].Puntaje += puntaje;
            Informacion();
            switch (indice)
            {
                case 0:
                    indice = 1;
                    break;
                case 1:
                    indice = 0;
                    break;
            }
            turnosJugados++;
            if(turnosJugados == 10)
            {
                tmrTiempoPartida.Stop();
                if (partidaActual.Jugadores[0].Puntaje > partidaActual.Jugadores[1].Puntaje)
                    partidaActual.Ganador = partidaActual.Jugadores[0].Nombre;
                else if (partidaActual.Jugadores[0].Puntaje < partidaActual.Jugadores[1].Puntaje)
                    partidaActual.Ganador = partidaActual.Jugadores[1].Nombre;
                else
                    partidaActual.Ganador = "Empate";

                MessageBox.Show("Ganador: " + partidaActual.Ganador);
                DialogResult = DialogResult.OK;
                try
                {
                    ConexionBd.GuardarPartida(partidaActual);    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ActualizarDatagrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = partidaActual.Jugadores;

        }

        
    }
}
