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

namespace Grafica
{
    public partial class frmMenuPrincipal : Form, IMostrador
    {
        PresentadorGenerico<frmMenuPrincipal> presentador;
        List<Jugador> jugadoresDisponibles;
        List<Jugador> jugadoresPartida;

        int indice;
        public frmMenuPrincipal()
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
            presentador = new PresentadorGenerico<frmMenuPrincipal>();
            jugadoresDisponibles = new List<Jugador>();
            jugadoresPartida = new List<Jugador>();
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
            //cambiar en algun momento
            nud_CantidadJugadores.Visible = true;
            lbl_Jugadores.Visible = true;
            btn_Aceptar.Visible = true;
         
        }

        private void btn_Full_Click(object sender, EventArgs e)
        {
           

            frmPartida partida = new frmPartida(jugadoresDisponibles, 31);
            this.Hide();
            if (partida.ShowDialog() == DialogResult.OK)
            {
                presentador.DevolverPartidas(this);
            }
            this.Show();

            ControlarSubmenu(pnl_Submenu);
        }

        private void btn_Jugadores_Click(object sender, EventArgs e)
        {
            if (dgv_MenuPrincipal.Visible == true)
            {
                dgv_MenuPrincipal.Visible = false;
            }
            else
            {
                presentador.DevolverJugadores(this);
                dgv_MenuPrincipal.Visible = true;
            }
        }

        public void MostrarDatos(List<Jugador> jugadors)
        {
            jugadoresDisponibles = jugadors;
            dgv_MenuPrincipal.DataSource = null;
            dgv_MenuPrincipal.DataSource = jugadors;
        }

        private void dgv_MenuPrincipal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void AgregarJugador(List<Jugador> jugadoresParaJugar)
        {
            if (!jugadoresParaJugar.Contains(this.jugadoresDisponibles[indice]))
            {
                jugadoresParaJugar.Add(this.jugadoresDisponibles[indice]);
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
                frmPartida partida = new frmPartida(jugadoresPartida, 11);
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
    }
}
