using Funcionalidad.clases;
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
using System.Runtime.CompilerServices;
using BibliotecaDeClases;

namespace Grafica
{
    public partial class frm_MenuPrincipal : Form, IMostradorUsuarios, IMostradorPartidas
    {
        PresentadorGenerico<frm_MenuPrincipal> presentador;
        List<Usuario> UsuariosDisponibles;
        List<Jugador> jugadoresPartida;
        Configuracion config;
        int indice;
        private int turnosAJugar;
        string reglas;
        private delegate void DelConfig();
        DelConfig delegado;
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ControlarSubmenu(pnl_Submenu);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;

        }


        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            presentador = new PresentadorGenerico<frm_MenuPrincipal>();
            UsuariosDisponibles = new List<Usuario>();
            jugadoresPartida = new List<Jugador>();
            delegado = CargarIdioma;
            delegado += CargarColor;
            delegado += CargarReglas;
            delegado();
        }

        private void btn_MostrarPartidas_Click(object sender, EventArgs e)
        {
            if (dgv_MenuPrincipal.Visible == true)
            {
                dgv_MenuPrincipal.Visible = false;
            }
            else
            {
                presentador.DevolverPartidas(this);
                dgv_MenuPrincipal.Visible = true;
            }
        
        }

        public void MostrarDatos(List<Partida> partidas)
        {

            dgv_MenuPrincipal.DataSource = null;
            dgv_MenuPrincipal.DataSource = partidas;
        }

        private void ControlarSubmenu( Panel panel)
        {
            if(panel.Visible== true)
            {
                panel.Visible = false;
            }else
            {
                panel.Visible = true;
            }
        }

        private void btn_Demo_Click(object sender, EventArgs e)
        {
            presentador.DevolverUsuarios(this);
            dgv_MenuPrincipal.Visible=true;
            nud_CantidadJugadores.Visible = true;
            lbl_Jugadores.Visible = true;
            btn_Aceptar.Visible = true;
            turnosAJugar = 3;
         
        }

        private void btn_Full_Click(object sender, EventArgs e)
        {
            MostrarDatos(UsuariosDisponibles);
            dgv_MenuPrincipal.Visible = true;
            nud_CantidadJugadores.Visible = true;
            lbl_Jugadores.Visible = true;
            btn_Aceptar.Visible = true;
            turnosAJugar = 6;
        }

        private void btn_Jugadores_Click(object sender, EventArgs e)
        {
            if (dgv_MenuPrincipal.Visible == true)
            {
                dgv_MenuPrincipal.Visible = false;
            }
            else
            {
                presentador.DevolverUsuarios(this);

                dgv_MenuPrincipal.Visible = true;
            }
        }

        public void MostrarDatos(List<Usuario> usuarios)
        {

            UsuariosDisponibles = usuarios;
            dgv_MenuPrincipal.DataSource = null;
            dgv_MenuPrincipal.DataSource = UsuariosDisponibles;
        }

        private void dgv_MenuPrincipal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void AgregarJugador(List<Jugador> jugadoresParaJugar)
        {
            Jugador jugadorAux = new Jugador(UsuariosDisponibles[indice]);
            if (!jugadoresParaJugar.Contains(jugadorAux))
            {
                jugadoresParaJugar.Add(jugadorAux);
            }
            else
            {
                throw new Exception("Ya Esta agregado este jugador");
            }
        }

        private bool IniciarPartida()
        {
            AgregarJugador(jugadoresPartida);
            if (jugadoresPartida.Count == nud_CantidadJugadores.Value)
            {
                frm_Partida partida = new frm_Partida(jugadoresPartida, 1+turnosAJugar*(int)(nud_CantidadJugadores.Value),config);
                this.Hide();
                if (partida.ShowDialog() == DialogResult.OK)
                {
                    presentador.DevolverPartidas(this);
                    jugadoresPartida.Clear();
                    return true;
                }
                else
                {
                    jugadoresPartida.Clear();
                    return true;
                }
                
            }
            return false;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (nud_CantidadJugadores.Enabled == true)
            {
                nud_CantidadJugadores.Enabled = false;
            }
            else
            {
                try
                {
                    if (IniciarPartida())
                    {
                        this.Show();
                        ControlarSubmenu(pnl_Submenu);
                        nud_CantidadJugadores.Enabled = true;
                        nud_CantidadJugadores.Visible = false;
                        btn_Aceptar.Visible = false;
                        lbl_Jugadores.Visible = false ;
                    }
                    
                
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btn_Reglas_Click(object sender, EventArgs e)
        {
            if (rtx_Reglas.Visible == false)
            {
                rtx_Reglas.Visible = true;
                dgv_MenuPrincipal.Visible = false;
                try
                {
                    rtx_Reglas.Text = reglas;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                rtx_Reglas.Visible = false;
            }

        }

        private void CargarIdioma()
        {
            config = Serializazdor<Configuracion>.LeerJSON("config");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(config.Idioma);
            lbl_Jugadores.Text = Res.Cantidad;
            btn_Aceptar.Text = Res.Aceptar;
            btn_Demo.Text = Res.Demo;
            btn_Partidas.Text = Res.Partidas;
            btn_Full.Text = Res.Juego;
            btn_Jugadores.Text = Res.Jugadores;
            btn_Salir.Text = Res.Salir;
            btn_PartidaNueva.Text = Res.Nueva;
        }

        private void CargarColor()
        {
            this.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            pnl_Menu.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            pnl_Submenu.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            pnl_Superior.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            btn_Aceptar.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_Configuracion.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_Demo.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_Full.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_Jugadores.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_PartidaNueva.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_Salir.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_Partidas.BackColor= Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_Reglas.BackColor= Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);

            lbl_Jugadores.ForeColor = Color.FromArgb(config.ForeColor[0],config.ForeColor[1],config.ForeColor[2]);
            btn_Aceptar.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            btn_Demo.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            btn_Partidas.ForeColor = Color.FromArgb(config.ForeColor[0],config.ForeColor[1],config.ForeColor[2]);
            btn_Full.ForeColor = Color.FromArgb(config.ForeColor[0],config.ForeColor[1],config.ForeColor[2]);
            btn_Jugadores.ForeColor = Color.FromArgb(config.ForeColor[0],config.ForeColor[1],config.ForeColor[2]);
            btn_Salir.ForeColor = Color.FromArgb(config.ForeColor[0],config.ForeColor[1],config.ForeColor[2]);
            btn_PartidaNueva.ForeColor = Color.FromArgb(config.ForeColor[0],config.ForeColor[1],config.ForeColor[2]);
            btn_Reglas.ForeColor = Color.FromArgb(config.ForeColor[0],config.ForeColor[1],config.ForeColor[2]);
            btn_Configuracion.ForeColor = Color.FromArgb(config.ForeColor[0],config.ForeColor[1],config.ForeColor[2]);


        }

        private void CargarReglas()
        {
            switch (config.Idioma)
            {
                case "":
                    reglas=Archivo.Leer("reglas.txt", @".\Reglas");
                    break;
                case "ja":
                    reglas=Archivo.Leer("reglasJa.txt", @".\Reglas");
                    break;
                case "en-US":
                    reglas = Archivo.Leer("reglasEn.txt", @".\Reglas");
                    break;
                case "pl":
                    reglas = Archivo.Leer("reglasPo.txt", @".\Reglas");
                    break;
                default:
                    break;

            }
        }

        private void btn_Configuracion_Click(object sender, EventArgs e)
        {
            frm_Configuracion con = new frm_Configuracion(config);
            this.Hide();
            if(con.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                delegado();
            }
        }
    }
}
