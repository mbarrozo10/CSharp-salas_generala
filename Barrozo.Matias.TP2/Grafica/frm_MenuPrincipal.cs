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
using System.Collections.Concurrent;
using Azure.Core;

namespace Grafica
{
    public partial class frm_MenuPrincipal : Form, IMenu
    {
        PresentadorPrincipal presentador;
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
        
        public frm_MenuPrincipal(Configuracion config):this()
        {
            this.config = config;
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
            presentador = new PresentadorPrincipal(this);


            presentador.ConseguirUsuarios();

            delegado = CargarIdioma;
            delegado += CargarColor;
            delegado += CargarReglas;
            delegado();
        }


        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            nud_CantidadJugadores.Enabled = true;
            pnl_Jugar.Visible = false;
            btn_CancelarPartida.Visible = false;


            if (dgv_MenuPrincipal.Visible == true && pnl_Estadisticas.Visible == true)
            {
                dgv_MenuPrincipal.Visible = false;
                pnl_Estadisticas.Visible = false;
            }
            else
            {
                try
                {
                    presentador.DevolverPartidas();
                    dgv_MenuPrincipal.Visible = true;
                    pnl_Estadisticas.Visible = true;
                    presentador.CargarEstadisticas();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void MostrarEstadisticas(string cantidad, string cantidadEmpatadas, string cantidadCanceladas, string cantidadFinalizada, List<Usuario> usuarios)
        {
            dgv_Top.DataSource = null;
            dgv_Top.DataSource = usuarios;
            lbl_CantidadPartidas.Text += " " + cantidad;
            lbl_PartidasEmpatadas.Text += " " + cantidadEmpatadas;
            lbl_PartidasCanceladas.Text += " " + cantidadCanceladas;
            lbl_PartidasFinalizada.Text += " " + cantidadFinalizada;
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
            pnl_Estadisticas.Visible = false;
            presentador.DevolverUsuarios();
            btn_CancelarPartida.Visible = false;

            ControlarSubmenu(pnl_Jugar);
            if(dgv_MenuPrincipal.Visible ==true)
            {
                dgv_MenuPrincipal.Visible= false;
            }else
            {
                dgv_MenuPrincipal.Visible = true;
            }

            turnosAJugar = 3;
        }

        private void btn_Full_Click(object sender, EventArgs e)
        {
            pnl_Estadisticas.Visible = false;
            btn_CancelarPartida.Visible = false;
            presentador.DevolverUsuarios();

            ControlarSubmenu(pnl_Jugar);
            if (dgv_MenuPrincipal.Visible == true)
            {
                dgv_MenuPrincipal.Visible = false;
            }
            else
            {
                dgv_MenuPrincipal.Visible = true;
            }
            turnosAJugar = 6;
        }

        private void btn_Jugadores_Click(object sender, EventArgs e)
        {
            pnl_Estadisticas.Visible = false;
            btn_CancelarPartida.Visible = false;

            if (dgv_MenuPrincipal.Visible == true)
            {
                dgv_MenuPrincipal.Visible = false;
            }
            else
            {

                dgv_MenuPrincipal.Visible = true;
                presentador.DevolverUsuarios();
            }
        }

        public void MostrarDatosUsuarios(List<Usuario> usuarios)
        {

            dgv_MenuPrincipal.DataSource = null;
            dgv_MenuPrincipal.DataSource = usuarios;
        }

        public void MostrarDatosPartidas(ConcurrentBag<Partida> partidas)
        {
            dgv_MenuPrincipal.DataSource = null;
            dgv_MenuPrincipal.DataSource = partidas.ToList();
        }


        private  void dgv_MenuPrincipal_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indice = e.RowIndex;
            if (nud_CantidadJugadores.Enabled == false)
            {
                try
                {
                    lbl_Seleccion.Visible = false;
                    presentador.AgregarJugador(indice);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(dgv_MenuPrincipal.DataSource== presentador.PartidasActivas)
            {
                if (!presentador.ListaDePresentadores[indice].enPantalla)
                {
                    frm_Partida partida = new frm_Partida(config, presentador.ListaDePresentadores[indice]);
                    partida.Show();
                }

            }
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            nud_CantidadJugadores.Enabled = false;
            lbl_Seleccion.Visible = true;
        }

        public void MostrarActivas(List<Partida> partidasActivas)
        {
            dgv_MenuPrincipal.DataSource = null;
            dgv_MenuPrincipal.DataSource = partidasActivas;
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
   

        private void btn_Configuracion_Click(object sender, EventArgs e)
        {
            frm_Configuracion con = new frm_Configuracion(config);
            this.Hide();
            if(con.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                delegado();
            }
            else
            {
                this.Show();
            }
        }

        public bool AgregarUsuario(List<Jugador> jugadoresPartida)
        {
            if (jugadoresPartida.Count == nud_CantidadJugadores.Value)
            {
                
                nud_CantidadJugadores.Enabled = true;
                pnl_Jugar.Visible = true;
                presentador.AgregarPartida(turnosAJugar * (int)nud_CantidadJugadores.Value);
                return true;
            }
            return false;
        }
        private void btn_Partidas_Click(object sender, EventArgs e)
        {
            ControlarSubmenu(pnl_Partidas);
        }

        private void btn_Activas_Click(object sender, EventArgs e)
        {
            presentador.TraerPartidasActivas();
            btn_CancelarPartida.Visible = true;
            pnl_Jugar.Visible = false;
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            ControlarSubmenu(pnl_Usuarios);
        }

        private void btn_AltaUsuarios_Click(object sender, EventArgs e)
        {
            btn_CancelarPartida.Visible = false;
            frm_AltaUsuarios users = new frm_AltaUsuarios(config);
            pnl_Jugar.Visible = false;
            this.Hide();
            if(users.ShowDialog()== DialogResult.OK)
            {
                presentador.ConseguirUsuarios();
            }
            this.Show();
        }

        private void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(config.Idioma);
            lbl_Jugadores.Text = Res.Cantidad;
            btn_AceptarCantidad.Text = Res.Aceptar;
            btn_Demo.Text = Res.Demo;
            btn_Partidas.Text = Res.Partidas;
            btn_Full.Text = Res.Juego;
            btn_Usuarios.Text = Res.Jugadores;
            btn_Salir.Text = Res.Salir;
            btn_PartidaNueva.Text = Res.Nueva;
            btn_Activas.Text = Res.Activas;
            btn_AltaUsuarios.Text = Res.Registro;
            btn_VerUsuarios.Text = Res.Existentes;
            lbl_Seleccion.Text = Res.Seleccion;
            lbl_CantidadPartidas.Text = Res.CantPartidas;
            lbl_PartidasCanceladas.Text = Res.CantPartidasCanceladas;
            lbl_PartidasEmpatadas.Text = Res.CantPartidasEmpatadas;
            lbl_PartidasFinalizada.Text = Res.CantPartidasFinalizadas;
            btn_CancelarPartida.Text = Res.CancelarPartida;
            btn_Estadisticas.Text = Res.Estadisticas;
            lbl_Top.Text = Res.Top;
            lbl_Titulo.Text = Res.Titulo;
        }

        private void CargarColor()
        {
            this.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            pnl_Menu.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            pnl_Submenu.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            pnl_Superior.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            btn_AceptarCantidad.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_Full.BackColor = Color.FromArgb(44, 44, 44);
            btn_Demo.BackColor = Color.FromArgb(44, 44, 44);


            btn_Configuracion.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            btn_Usuarios.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            btn_PartidaNueva.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            btn_Salir.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            btn_Partidas.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            btn_Reglas.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            btn_Estadisticas.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
           
            pnl_Jugar.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);

            lbl_Jugadores.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            btn_AceptarCantidad.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            lbl_Titulo.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);

        }

        private void CargarReglas()
        {
            try
            {
                switch (config.Idioma)
                {
                    case "":
                        reglas = Archivo.Leer("reglas.txt", @".\Reglas");
                        break;
                    case "ja":
                        reglas = Archivo.Leer("reglasJa.txt", @".\Reglas");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgv_MenuPrincipal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indice = e.RowIndex;
        }
        private void btn_CancelarPartida_Click(object sender, EventArgs e)
        {
            presentador.CancelarPartida(indice);
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
