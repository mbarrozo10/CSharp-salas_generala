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
    public partial class frm_Partida : Form/*, IPartida*/
    {
        DateTime hora = new DateTime(2022, 1, 2, 0, 0, 0);
        Configuracion config;
        PresentadorPartida presentador;
        bool primerTirada = true;
        Image[] imagenes = new Image[7]; 
        public frm_Partida()
        {
            InitializeComponent();
        }

        public frm_Partida(Configuracion config, PresentadorPartida presentadorg) : this()
        {
            presentador= presentadorg;
            presentador.PartidaActual.prueba += Informacion;
            presentador.PartidaActual.prueba += ActualizarDatagrid;
            presentador.PartidaActual.finalizar += FinalizarPartida;
            presentador.enPantalla = true;
            this.config = config;
            CargarIdioma();
            CargarColores();
        }
        private void frmPartida_Load(object sender, EventArgs e)
        {
            tmrTiempoPartida.Start();

            imagenes[1] = Res.dado1; 
            imagenes[2] = Res.dado2; 
            imagenes[3] = Res.dado3; 
            imagenes[4] = Res.dado4; 
            imagenes[5] = Res.dado5; 
            imagenes[6] = Res.dado6;            
        }
        delegate void SetTextCallback(Partida text);

        public void Informacion(Partida partidaActual)
        {
            if (lblTurnoJugador.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Informacion);
                this.Invoke(d, new object[] { partidaActual });
            }
            else
            {
                lblTurnoJugador.Text = Res.Turno + partidaActual.turnosJugados + " " + Res.Tirada + " " + partidaActual.Jugadores[partidaActual.indice].TurnosJugados + " " + Res.De + partidaActual.Jugadores[partidaActual.indice].Usuario.Nombre;


                pic_DadoUno.Image = imagenes[partidaActual.dadosEnMesa[0]];
                pic_DadoDos.Image = imagenes[partidaActual.dadosEnMesa[1]];
                pic_DadoTres.Image = imagenes[partidaActual.dadosEnMesa[2]];
                pic_DadoCuatro.Image = imagenes[partidaActual.dadosEnMesa[3]];
                pic_DadoCinco.Image = imagenes[partidaActual.dadosEnMesa[4]];

                if (config.Idioma == "ja")
                {
                    lbl_Jugador1.Text = Res.Jugador + partidaActual.Jugadores[0].Usuario.Nombre + "-san";
                    lbl_Jugador2.Text = Res.Jugador + partidaActual.Jugadores[1].Usuario.Nombre + "-san";
                }
                else
                {
                    lbl_Jugador1.Text = Res.Jugador + partidaActual.Jugadores[0].Usuario.Nombre;
                    lbl_Jugador2.Text = Res.Jugador + partidaActual.Jugadores[1].Usuario.Nombre;
                }
                if (partidaActual.Jugadores.Count > 2)
                {
                    lbl_Jugador3.Visible = true;
                    if (config.Idioma == "ja")
                    {
                        lbl_Jugador3.Text = Res.Jugador + partidaActual.Jugadores[2].Usuario.Nombre + "-san";
                    }
                    else
                    {
                        lbl_Jugador3.Text = Res.Jugador + partidaActual.Jugadores[2].Usuario.Nombre;
                    }
                }
                if (partidaActual.Jugadores.Count > 3)
                {
                    lbl_Jugador4.Visible = true;
                    if (config.Idioma == "ja")
                    {
                        lbl_Jugador3.Text = Res.Jugador + partidaActual.Jugadores[3].Usuario.Nombre + "-san";
                    }
                    else
                    {
                        lbl_Jugador3.Text = Res.Jugador + partidaActual.Jugadores[3].Usuario.Nombre;
                    }
                }
            }
        }

        private void tmrTiempoPartida_Tick(object sender, EventArgs e)
        {
            TirarDados();
        }

        private void TirarDados()
        {
            hora = hora.AddSeconds(1);
            lblTiempoPartida.Text = hora.ToString("mm:ss");
            
        }

        public void ActualizarDatagrid(Partida partidaActual)
        {
            if (dataGridView1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ActualizarDatagrid);
                this.Invoke(d, new object[] { partidaActual });
            }
            else
            {
               
                if (primerTirada)
                {
                    primerTirada = false;
                    if (partidaActual.Jugadores.Count > 2)
                    {
                        if (config.Idioma == "ja")
                        {
                            dataGridView1.Columns.Add("jugador3", partidaActual.Jugadores[2].Usuario.Nombre + "-san");
                        }
                        else
                        {
                            dataGridView1.Columns.Add("jugador3", partidaActual.Jugadores[2].Usuario.Nombre);
                        }
                    }
                    if (partidaActual.Jugadores.Count > 3)
                    {
                        if (config.Idioma == "ja")
                        {
                            dataGridView1.Columns.Add("jugador3", partidaActual.Jugadores[3].Usuario.Nombre + "-san");
                        }
                        else
                        {
                            dataGridView1.Columns.Add("jugador3", partidaActual.Jugadores[3].Usuario.Nombre);
                        }
                    }
                }
                if (config.Idioma == "ja")
                {
                    dataGridView1.Columns[1].HeaderText = partidaActual.Jugadores[0].Usuario.Nombre+ "-san";
                    dataGridView1.Columns[2].HeaderText = partidaActual.Jugadores[1].Usuario.Nombre +"-san";
                }
                else
                {
                    dataGridView1.Columns[1].HeaderText = partidaActual.Jugadores[0].Usuario.Nombre;
                    dataGridView1.Columns[2].HeaderText = partidaActual.Jugadores[1].Usuario.Nombre;
                }
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                DataGridViewRow[] filas = new DataGridViewRow[12];
                filas[0] = CrearFilas("Full");
                filas[0].Cells[1].Value = partidaActual.Jugadores[0].Full;
                filas[0].Cells[2].Value = partidaActual.Jugadores[1].Full;

                filas[1] = CrearFilas("Poker");
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
                    CompletarJugadoresExtras(filas, 2, 3, partidaActual);

                }
                if (partidaActual.Jugadores.Count > 3)
                {
                    CompletarJugadoresExtras(filas, 3, 4, partidaActual);
                }
                for (int i = 0; i < filas.Length; i++)
                {
                    dataGridView1.Rows.Add(filas[i]);
                }
            }
          
        }

        private DataGridViewRow CrearFilas( string titulo)
        {
            DataGridViewRow filas = new DataGridViewRow();
            filas.CreateCells(dataGridView1);
            filas.Cells[0].Value = titulo;
            return filas;
        }

        private void CompletarJugadoresExtras(DataGridViewRow[] filas,int indice,int columna, Partida partidaActual)
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

            presentador.PartidaActual.prueba -= ActualizarDatagrid;
            presentador.PartidaActual.prueba -= Informacion;
            presentador.PartidaActual.finalizar -= FinalizarPartida;
            presentador.enPantalla = false;
            this.Close();
        }

        void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(config.Idioma);
            btn_Volver.Text = Res.Volver;
            lbl_Guardar.Text = Res.Bitacora;
            btn_Aceptar.Text = Res.Aceptar;
            btn_Cancelar.Text = Res.Cancelar;
            lbl_Ubicacion.Text = Res.Ubicacion;
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

            pnl_Superior.BackColor= Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                presentador.PartidaActual.GuardarResumenPartida();
                presentador.PartidaActual.GuardarPartida();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                presentador.PartidaActual.GuardarPartida();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    
        public void FinalizarPartida(Partida ganador)
        {
            tmrTiempoPartida.Stop();
            if (pnl_GuardarPartida.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(FinalizarPartida);
                this.Invoke(d, new object[] { ganador });
            }
            else
            {
                MessageBox.Show(Res.Ganador + ganador.Ganador);
                pnl_GuardarPartida.Visible = true;
               
            }
        }

        int m, mx, my;

        private void pnl_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pnl_Superior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pnl_Superior_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
