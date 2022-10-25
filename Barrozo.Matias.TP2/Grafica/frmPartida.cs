using Funcionalidad;
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
        int turnosJugados = 1;
        int turnosMaximos;
        public frmPartida()
        {
            InitializeComponent();
        }
        
        public frmPartida(List<Jugador> jugadores, int turnos): this()
        {
            jugadoresActivos=jugadores;
            tmrTiempoPartida.Start();
            partidaActual = new Partida(jugadores, "",jugadores.Count, DateTime.Now,1);
            turnosMaximos = turnos;
        }

        private void frmPartida_Load(object sender, EventArgs e)
        {
            Informacion();
            if (jugadoresActivos.Count > 2)
            {
                dataGridView1.Columns.Add("jugador3", jugadoresActivos[2].Nombre);
            }
            if (jugadoresActivos.Count > 3)
            {
                dataGridView1.Columns.Add("jugador4", jugadoresActivos[3].Nombre);
            }
            ActualizarDatagrid();
        }

        private void Informacion()
        {

             lbl_Jugador1.Text = "Jugador: "+ jugadoresActivos[0].Nombre + "  Puntaje: " + jugadoresActivos[0].Puntaje;
            lbl_Jugador2.Text = "Jugador: " + jugadoresActivos[1].Nombre + "  Puntaje: " + jugadoresActivos[1].Puntaje;
            if (jugadoresActivos.Count > 2)
            {
                lbl_Jugador3.Visible = true;
                lbl_Jugador3.Text = "Jugador: " + jugadoresActivos[2].Nombre + "  Puntaje: " + jugadoresActivos[2].Puntaje;
            }
            if(jugadoresActivos.Count > 3)
            {
                lbl_Jugador4.Visible = true;
                lbl_Jugador4.Text = "Jugador: " + jugadoresActivos[3].Nombre + "  Puntaje: " + jugadoresActivos[3].Puntaje;
            }
        }

        private void tmrTiempoPartida_Tick(object sender, EventArgs e)
        {
            TirarDados();
        }

        private void TirarDados()
        {
            //Jugador jugadorActual = partidaActual.Jugadores[indice];
            lblTurnoJugador.Text = "Turno: " + turnosJugados + " de : " + jugadoresActivos[indice].Nombre;
            hora = hora.AddSeconds(1);
            lblTiempoPartida.Text = hora.ToString("mm:ss");
            int horaInt = int.Parse(hora.ToString("ss"));
         
                if (horaInt % 2 == 0)

                {
                    int[] aux = partidaActual.TirarDados(5);
                    lbl_Dados.Text = "Tirada: " + aux[0].ToString();
                    lbl_Dados.Text += "-" + aux[1].ToString();
                    lbl_Dados.Text += "-" + aux[2].ToString();
                    lbl_Dados.Text += "-" + aux[3].ToString();
                    lbl_Dados.Text += "-" + aux[4].ToString();

                    if (jugadoresActivos[indice].CheckGenerala(aux) && jugadoresActivos[indice].Generala == 0)
                    {
                        jugadoresActivos[indice].Generala = 60;
                        jugadoresActivos[indice].Puntaje += 60;

                        CambiarJugador();
                    }
                    else if (jugadoresActivos[indice].CheckGenerala(aux) && jugadoresActivos[indice].DobleGenerala == 0 && jugadoresActivos[indice].Generala != 0)
                    {
                        jugadoresActivos[indice].DobleGenerala = 60;
                        jugadoresActivos[indice].Puntaje += 60;


                        CambiarJugador();
                    }
                    else if (jugadoresActivos[indice].CheckEscalera(aux) && jugadoresActivos[indice].Escalera == 0)
                    {
                        jugadoresActivos[indice].Escalera = 20;
                        jugadoresActivos[indice].Puntaje += 20;

                        CambiarJugador();
                    }
                    else if (jugadoresActivos[indice].CheckFull(aux) && jugadoresActivos[indice].Full == 0)
                    {
                        jugadoresActivos[indice].Full = 40;
                        jugadoresActivos[indice].Puntaje += 40;

                        CambiarJugador();
                    }
                    else if (jugadoresActivos[indice].CheckPoker(aux) && jugadoresActivos[indice].Poker == 0)
                    {
                        jugadoresActivos[indice].Poker = 30;
                        jugadoresActivos[indice].Puntaje += 30;

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
            tiradasJugador = 0;
            Informacion();
            if(indice != jugadoresActivos.Count-1)
            {
                indice++;
            }
            else
            {
                indice = 0;
            }
            turnosJugados++;
            if(turnosJugados == turnosMaximos)
            {
                ActualizarDatagrid();
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
            dataGridView1.Columns[1].HeaderText = jugadoresActivos[0].Nombre;
            dataGridView1.Columns[2].HeaderText = jugadoresActivos[1].Nombre;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataGridViewRow[] filas = new DataGridViewRow[6];
            filas[0]=CrearFilas("Full");
            filas[0].Cells[1].Value = jugadoresActivos[0].Full;
            filas[0].Cells[2].Value = jugadoresActivos[1].Full;

            filas[1]=CrearFilas("Poker");
            filas[1].Cells[1].Value = jugadoresActivos[0].Poker;
            filas[1].Cells[2].Value = jugadoresActivos[1].Poker;

            filas[2] = CrearFilas("Escalera");
            filas[2].Cells[1].Value = jugadoresActivos[0].Escalera;
            filas[2].Cells[2].Value = jugadoresActivos[1].Escalera;

            filas[3] = CrearFilas("Generala");
            filas[3].Cells[1].Value = jugadoresActivos[0].Generala;
            filas[3].Cells[2].Value = jugadoresActivos[1].Generala;

            filas[4] = CrearFilas("Generala Doble");
            filas[4].Cells[1].Value = jugadoresActivos[0].DobleGenerala;
            filas[4].Cells[2].Value = jugadoresActivos[1].DobleGenerala;

            filas[5] = CrearFilas("Puntaje Final");
            filas[5].Cells[1].Value = jugadoresActivos[0].Puntaje;
            filas[5].Cells[2].Value = jugadoresActivos[1].Puntaje;

            if (jugadoresActivos.Count > 2)
            {
                filas[0].Cells[3].Value = jugadoresActivos[2].Full;
                filas[1].Cells[3].Value = jugadoresActivos[2].Poker;
                filas[2].Cells[3].Value = jugadoresActivos[2].Escalera;
                filas[3].Cells[3].Value = jugadoresActivos[2].Generala;
                filas[4].Cells[3].Value = jugadoresActivos[2].DobleGenerala;
                filas[5].Cells[3].Value = jugadoresActivos[2].Puntaje;
            }
            if(jugadoresActivos.Count > 4)
            {
                filas[0].Cells[4].Value = jugadoresActivos[3].Full;
                filas[1].Cells[4].Value = jugadoresActivos[3].Poker;
                filas[2].Cells[4].Value = jugadoresActivos[3].Escalera;
                filas[3].Cells[4].Value = jugadoresActivos[3].Generala;
                filas[4].Cells[4].Value = jugadoresActivos[3].DobleGenerala;
                filas[5].Cells[4].Value = jugadoresActivos[3].Puntaje;
            }
            dataGridView1.Rows.Add(filas[0]);
            dataGridView1.Rows.Add(filas[1]);
            dataGridView1.Rows.Add(filas[2]);
            dataGridView1.Rows.Add(filas[3]);
            dataGridView1.Rows.Add(filas[4]);
            dataGridView1.Rows.Add(filas[5]);
        }

        private DataGridViewRow CrearFilas( string titulo)
        {
            DataGridViewRow filas = new DataGridViewRow();
            filas = new DataGridViewRow();
            filas.CreateCells(dataGridView1);
            filas.Cells[0].Value = titulo;
      

            return filas;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
