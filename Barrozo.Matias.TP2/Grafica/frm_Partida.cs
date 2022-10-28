using BibliotecaDeClases;
using Funcionalidad;
using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafica
{
    public partial class frm_Partida : Form, IPartida
    {
        DateTime hora = new DateTime(2022, 1, 2, 0, 0, 0);
        //List<Jugador> jugadoresActivos= new List<Jugador>();
        Partida partidaActual;
        int indice=0;
        //int tiradasJugador = 1;
        int turnosJugados = 1;
        int turnosMaximos;
        int[] dadosEnMesa = new int[5];
        Configuracion config;
        string bitacora="";
        PresentadorGenerico<frm_Partida> presentador;
        private int ultimoId;

        public frm_Partida()
        {
            InitializeComponent();
        }
        
        public frm_Partida(List<Jugador> jugadores, int turnos, Configuracion config) : this()
        {
            presentador = new PresentadorGenerico<frm_Partida>();
            //jugadoresActivos = jugadores;
            tmrTiempoPartida.Start();
            presentador.ConseguirUltimoId(this);
            partidaActual = new Partida(jugadores, "",jugadores.Count, DateTime.Now,ultimoId);
            turnosMaximos = turnos;
            this.config = config;
            CargarIdioma();
            CargarColores();
        }

      

        private void frmPartida_Load(object sender, EventArgs e)
        {
            Informacion();
            if (partidaActual.Jugadores.Count > 2)
            {
                dataGridView1.Columns.Add("jugador3", partidaActual.Jugadores[2].Usuario.Nombre);
            }
            if (partidaActual.Jugadores.Count > 3)
            {
                dataGridView1.Columns.Add("jugador4", partidaActual.Jugadores[3].Usuario.Nombre);
            }
            ActualizarDatagrid();
        }

        private void Informacion()
        {

             lbl_Jugador1.Text = Res.Jugador + partidaActual.Jugadores[0].Usuario.Nombre + " "+ Res.Puntaje + partidaActual.Jugadores[0].Puntaje;
            lbl_Jugador2.Text = Res.Jugador + partidaActual.Jugadores[1].Usuario.Nombre + " " + Res.Puntaje + partidaActual.Jugadores[1].Puntaje;
            if (partidaActual.Jugadores.Count > 2)
            {
                lbl_Jugador3.Visible = true;
                lbl_Jugador3.Text = Res.Jugador + partidaActual.Jugadores[2].Usuario.Nombre + " " + Res.Puntaje + partidaActual.Jugadores[2].Puntaje;
            }
            if(partidaActual.Jugadores.Count > 3)
            {
                lbl_Jugador4.Visible = true;
                lbl_Jugador4.Text = Res.Jugador + partidaActual.Jugadores[3].Usuario.Nombre + " " + Res.Puntaje + partidaActual.Jugadores[3].Puntaje;
            }
        }

        private void tmrTiempoPartida_Tick(object sender, EventArgs e)
        {
            TirarDados();
        }

        private void TirarDados()
        {
            lblTurnoJugador.Text = Res.Turno + turnosJugados +" " + Res.Tirada +" "  + partidaActual.Jugadores[indice].TurnosJugados +" "  + Res.De + partidaActual.Jugadores[indice].Usuario.Nombre;
            hora = hora.AddSeconds(1);
            lblTiempoPartida.Text = hora.ToString("mm:ss");
            int horaInt = int.Parse(hora.ToString("ss"));
            if (horaInt % 2 == 0)
            {
                if (partidaActual.Jugadores[indice].TurnosJugados == 1)
                {
                     partidaActual.TirarDados(5, -1, dadosEnMesa);
                }
                else
                {
                    int numeroAGuardar = Partida.GuardarNumero(dadosEnMesa);
                    partidaActual.TirarDados(5, numeroAGuardar, dadosEnMesa);
                }
                //partidaActual.Jugadores[indice].TurnosJugados++;
                lbl_Dados.Text = Res.Tirada + dadosEnMesa[0].ToString();
                lbl_Dados.Text += "-" + dadosEnMesa[1].ToString();
                lbl_Dados.Text += "-" + dadosEnMesa[2].ToString();
                lbl_Dados.Text += "-" + dadosEnMesa[3].ToString();
                lbl_Dados.Text += "-" + dadosEnMesa[4].ToString();

               // revisar en futuro
                presentador.Revisar(this, partidaActual.Jugadores[indice]);

                bitacora += lblTurnoJugador.Text + lbl_Dados.Text + "\n";

                if (partidaActual.Jugadores[indice].TurnosJugados == 4 || partidaActual.Jugadores[indice].TerminoTurno)
                {
                    partidaActual.Jugadores[indice].AsignarANumeros(dadosEnMesa);
                    partidaActual.Jugadores[indice].TerminoTurno = false;

                    //partidaActual.Jugadores[indice].TurnosJugados = 1;
                    CambiarJugador();
                }
                ActualizarDatagrid();
           
            }
        }

        private void CambiarJugador()
        {
            dadosEnMesa = new int[5];
            Informacion();
            if(indice != partidaActual.Jugadores.Count-1)
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

                partidaActual.Ganador = EncontrarGanador();
                MessageBox.Show(Res.Ganador + partidaActual.Ganador);
                pnl_GuardarPartida.Visible = true;

               
            }

        }

        string EncontrarGanador()
        {
            string ganador=Res.Empate;
            int puntajeMaximo = 0;
            foreach (Jugador jugador in partidaActual.Jugadores)
            {
                if (jugador.Puntaje > puntajeMaximo)
                {
                    puntajeMaximo = jugador.Puntaje;
                    ganador = jugador.Usuario.Nombre;
                }
                else if(jugador.Puntaje == puntajeMaximo)
                {
                    ganador = Res.Empate;
                }
            }

            return ganador;
        }

        private void ActualizarDatagrid()
        {
            dataGridView1.Columns[1].HeaderText = partidaActual.Jugadores[0].Usuario.Nombre;
            dataGridView1.Columns[2].HeaderText = partidaActual.Jugadores[1].Usuario.Nombre;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataGridViewRow[] filas = new DataGridViewRow[12];
            filas[0]=CrearFilas("Full");
            filas[0].Cells[1].Value = partidaActual.Jugadores[0].Full;
            filas[0].Cells[2].Value = partidaActual.Jugadores[1].Full;

            filas[1]=CrearFilas("Poker");
            filas[1].Cells[1].Value = partidaActual.Jugadores[0].Poker;
            filas[1].Cells[2].Value = partidaActual.Jugadores[1].Poker;

            filas[2] = CrearFilas("Escalera");
            filas[2].Cells[1].Value = partidaActual.Jugadores[0].Escalera;
            filas[2].Cells[2].Value = partidaActual.Jugadores[1].Escalera;

            filas[3] = CrearFilas("Generala");
            filas[3].Cells[1].Value = partidaActual.Jugadores[0].Generala;
            filas[3].Cells[2].Value = partidaActual.Jugadores[1].Generala;

            filas[4] = CrearFilas("Generala Doble");
            filas[4].Cells[1].Value = partidaActual.Jugadores[0].DobleGenerala;
            filas[4].Cells[2].Value = partidaActual.Jugadores[1].DobleGenerala;

            filas[5] = CrearFilas("1");
            filas[5].Cells[1].Value = partidaActual.Jugadores[0].Uno;
            filas[5].Cells[2].Value = partidaActual.Jugadores[1].Uno;
            
            filas[6] = CrearFilas("2");
            filas[6].Cells[1].Value = partidaActual.Jugadores[0].Dos;
            filas[6].Cells[2].Value = partidaActual.Jugadores[1].Dos;

            filas[7] = CrearFilas("3");
            filas[7].Cells[1].Value = partidaActual.Jugadores[0].Tres;
            filas[7].Cells[2].Value = partidaActual.Jugadores[1].Tres;

            filas[8] = CrearFilas("4");
            filas[8].Cells[1].Value = partidaActual.Jugadores[0].Cuatro;
            filas[8].Cells[2].Value = partidaActual.Jugadores[1].Cuatro;
            
            filas[9] = CrearFilas("5");
            filas[9].Cells[1].Value = partidaActual.Jugadores[0].Cinco;
            filas[9].Cells[2].Value = partidaActual.Jugadores[1].Cinco;
            
            filas[10] = CrearFilas("6");
            filas[10].Cells[1].Value = partidaActual.Jugadores[0].Seis;
            filas[10].Cells[2].Value = partidaActual.Jugadores[1].Seis;
            
            filas[11] = CrearFilas("Puntaje Final");
            filas[11].Cells[1].Value = partidaActual.Jugadores[0].Puntaje;
            filas[11].Cells[2].Value = partidaActual.Jugadores[1].Puntaje;

            if (partidaActual.Jugadores.Count > 2)
            {
                CompletarJugadoresExtras(filas, 2,3);

            }
            if (partidaActual.Jugadores.Count > 3)
            {
                CompletarJugadoresExtras(filas, 3,4);
            }
            for(int i = 0; i < filas.Length; i++)
            {
                dataGridView1.Rows.Add(filas[i]);
            }
          
        }

        private DataGridViewRow CrearFilas( string titulo)
        {
            DataGridViewRow filas = new DataGridViewRow();
            filas.CreateCells(dataGridView1);
            filas.Cells[0].Value = titulo;
            return filas;
        }

        private void CompletarJugadoresExtras(DataGridViewRow[] filas,int indice,int columna)
        {
            filas[0].Cells[columna].Value = partidaActual.Jugadores[indice].Full;
            filas[1].Cells[columna].Value = partidaActual.Jugadores[indice].Poker;
            filas[2].Cells[columna].Value = partidaActual.Jugadores[indice].Escalera;
            filas[3].Cells[columna].Value = partidaActual.Jugadores[indice].Generala;
            filas[4].Cells[columna].Value = partidaActual.Jugadores[indice].DobleGenerala;
            filas[5].Cells[columna].Value = partidaActual.Jugadores[indice].Uno;
            filas[6].Cells[columna].Value = partidaActual.Jugadores[indice].Dos;
            filas[7].Cells[columna].Value = partidaActual.Jugadores[indice].Tres;
            filas[8].Cells[columna].Value = partidaActual.Jugadores[indice].Cuatro;
            filas[9].Cells[columna].Value = partidaActual.Jugadores[indice].Cinco;
            filas[10].Cells[columna].Value = partidaActual.Jugadores[indice].Seis;
            filas[11].Cells[columna].Value = partidaActual.Jugadores[indice].Puntaje;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {

            tmrTiempoPartida.Stop();
            DialogResult = DialogResult.Cancel;
        }

        void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(config.Idioma);
            btn_Volver.Text = Res.Volver;
            lbl_Guardar.Text = Res.Bitacora;
        }

        private void CargarColores()
        {
            this.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_Volver.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            lblTiempoPartida.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            lblTurnoJugador.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            lbl_Dados.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            lbl_Jugador1.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            lbl_Jugador2.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            lbl_Jugador3.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            lbl_Jugador4.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            btn_Volver.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);

            pnl_GuardarPartida.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[1]);
            pnl_Superior.BackColor= Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string archivo = "BitacoraDePartida" + partidaActual.Id;
                Archivo.Escribir(bitacora, archivo, @".\Bitacoras");
                ConexionBd.GuardarPartida(partidaActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBd.GuardarPartida(partidaActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
        }

        public void DevolverTiradas(Jugador.DTiradas delegado)
        {
            delegado(dadosEnMesa);
        }

        public void ConseguirUltimoId(int id)
        {
            ultimoId = id+1;
        }
    }
}
