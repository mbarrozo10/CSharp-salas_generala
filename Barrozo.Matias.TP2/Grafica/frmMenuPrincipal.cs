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
    public partial class frmMenuPrincipal : Form, IPartida
    {
        List<Partida> partidas;
        PresentadorGenerico<frmMenuPrincipal> presentador;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(new Jugador("Nico", 0));
            jugadores.Add(new Jugador("Mati", 0));


            frmPartida partida = new frmPartida(jugadores);
            this.Hide();
            if(partida.ShowDialog()== DialogResult.OK)
            {
                MostrarDatos();
            }
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;

        }


        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            presentador = new PresentadorGenerico<frmMenuPrincipal>();
            MostrarDatos();
        }

        private void btn_MostrarPartidas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true)
            {
                dataGridView1.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
            }
        
        }

        public void MostrarDatos()
        {
            partidas = presentador.DevolverPartidas(this);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = partidas;
        }
    }
}
