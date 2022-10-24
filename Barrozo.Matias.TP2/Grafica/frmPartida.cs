using Funcionalidad.clases;
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
            lbljugador1.Text = "Jugador: "+ jugadoresActivos[0].Nombre + "  Puntaje: " + jugadoresActivos[0].Puntaje;
            lbljugador2.Text = "Jugador: " + jugadoresActivos[1].Nombre + "  Puntaje: " + jugadoresActivos[1].Puntaje;
        }

        private void tmrTiempoPartida_Tick(object sender, EventArgs e)
        {
            Jugador jugadorActual = partidaActual.Jugadores[indice];
            lblTurnoJugador.Text ="Turno de : " + jugadorActual.Nombre;
            hora = hora.AddSeconds(1);
            lblTiempoPartida.Text = hora.ToString("mm:ss");
            int horaInt = int.Parse(hora.ToString("ss"));
            if (horaInt % 2 == 0)
            {
                int[] aux = partidaActual.TirarDados(5);
               lbldados.Text ="Tirada: "+ aux[0].ToString();
               lbldados.Text += "-"+ aux[1].ToString();
               lbldados.Text += "-" + aux[2].ToString();
               lbldados.Text += "-" + aux[3].ToString();
               lbldados.Text += "-" + aux[4].ToString();

                if (Partida.CheckGenerala(aux) && jugadorActual.Generala ==0 )
                {
                    partidaActual.Jugadores[indice].Generala = 60;
                    partidaActual.Jugadores[indice].Puntaje += 60;
                    
                    CambiarJugador();
                }
                else if(Partida.CheckGenerala(aux) && jugadorActual.DobleGenerala == 0 && jugadorActual.Generala!=0)
                {
                    partidaActual.Jugadores[indice].DobleGenerala = 60;
                    partidaActual.Jugadores[indice].Puntaje += 60;

                    CambiarJugador();
                }
                else if(Partida.CheckEscalera(aux) && jugadorActual.Escalera==0)
                {
                    partidaActual.Jugadores[indice].Escalera = 20;
                    partidaActual.Jugadores[indice].Puntaje += 20;

                    CambiarJugador();
                }
                else if(Partida.CheckFull(aux) && jugadorActual.Full == 0)
                {
                    partidaActual.Jugadores[indice].Full = 40;
                    partidaActual.Jugadores[indice].Puntaje += 40;

                    CambiarJugador();
                }
                else if(Partida.CheckPoker(aux) && jugadorActual.Poker==0)
                {
                    partidaActual.Jugadores[indice].Poker = 30;
                    partidaActual.Jugadores[indice].Puntaje += 30;

                    CambiarJugador();
                }
              
                tiradasJugador++;
                

                if (tiradasJugador == 3)
                {
                    tiradasJugador = 0;
                    CambiarJugador();
                }
                ActualizarDatagrid();
            }
        }

        private void CambiarJugador()
        {
            //partidaActual.Jugadores[indice].Puntaje += puntaje;
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
        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = partidaActual.Jugadores;

         
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataGridViewRow[] filas = new DataGridViewRow[7]; 

            filas[0] = new DataGridViewRow();
            filas[0].CreateCells(dataGridView1);
            filas[0].Cells[0].Value = "Full";
            filas[0].Cells[1].Value = jugadoresActivos[0].Full;
            filas[0].Cells[2].Value = jugadoresActivos[1].Full;
            dataGridView1.Rows.Add(filas[0]);

            filas[1]= new DataGridViewRow();
            filas[1].CreateCells(dataGridView1);
            filas[1].Cells[0].Value = "Poker";
            filas[1].Cells[1].Value = jugadoresActivos[0].Poker;
            filas[1].Cells[2].Value = jugadoresActivos[1].Poker;
            dataGridView1.Rows.Add(filas[1]);

            filas[2]= new DataGridViewRow();
            filas[2].CreateCells(dataGridView1);
            filas[2].Cells[0].Value = "Escalera";
            filas[2].Cells[1].Value = jugadoresActivos[0].Escalera;
            filas[2].Cells[2].Value = jugadoresActivos[1].Escalera;
            dataGridView1.Rows.Add(filas[2]);

            filas[3]= new DataGridViewRow();
            filas[3].CreateCells(dataGridView1);
            filas[3].Cells[0].Value = "Generala";
            filas[3].Cells[1].Value = jugadoresActivos[0].Generala;
            filas[3].Cells[2].Value = jugadoresActivos[1].Generala;
            dataGridView1.Rows.Add(filas[3]);

            filas[4]= new DataGridViewRow();
            filas[4].CreateCells(dataGridView1);
            filas[4].Cells[0].Value = "Generala Doble";
            filas[4].Cells[1].Value = jugadoresActivos[0].DobleGenerala;
            filas[4].Cells[2].Value = jugadoresActivos[1].DobleGenerala;
            dataGridView1.Rows.Add(filas[4]);

            filas[5]= new DataGridViewRow();
            filas[5].CreateCells(dataGridView1);
            filas[5].Cells[0].Value = "Puntaje Final";
            filas[5].Cells[1].Value = jugadoresActivos[0].Puntaje;
            filas[5].Cells[2].Value = jugadoresActivos[1].Puntaje;
            dataGridView1.Rows.Add(filas[5]);
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
