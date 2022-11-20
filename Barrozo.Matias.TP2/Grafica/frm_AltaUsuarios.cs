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
    public partial class frm_AltaUsuarios : Form, IAlta
    {
        Configuracion config;
        PresentadorAlta PresentadorAlta;
        public frm_AltaUsuarios(Configuracion config)
        {
            InitializeComponent();
            this.config = config;
        }

        private void frm_AltaUsuarios_Load(object sender, EventArgs e)
        {
            CambiarIdioma();
            CambiarColor();
            PresentadorAlta = new PresentadorAlta(this);
        }

        private void CambiarColor()
        {
            this.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);

            pnl_Superior.BackColor = Color.FromArgb(config.ColorSecundario[0],config.ColorSecundario[1],config.ColorSecundario[2]);
            pnl_Fondo.BackColor = Color.FromArgb(config.ColorSecundario[0],config.ColorSecundario[1],config.ColorSecundario[2]);
            txt_Nombre.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            txt_Apellido.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            txt_Usuario.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            txt_Contraseña.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
        }

        private void CambiarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(config.Idioma);

            btn_Aceptar.Text = Res.Aceptar;
            btn_Cancelar.Text = Res.Cancelar;
            lbl_Alta.Text = Res.Registro;
            txt_Apellido.PlaceholderText = Res.Apellido;
            txt_Contraseña.PlaceholderText = Res.Contraseña;
            txt_Nombre.PlaceholderText = Res.Nombre;
            txt_Usuario.PlaceholderText = Res.Usuario;
            lbl_Error.Text = Res.ErrorLogin;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text != string.Empty && txt_Nombre.Text!=string.Empty&& txt_Usuario.Text != string.Empty && txt_Contraseña.Text!= string.Empty && txt_Apellido.Text!= string.Empty)
            {
                PresentadorAlta.AgregarUsuario(txt_Nombre.Text, txt_Apellido.Text, txt_Usuario.Text, txt_Contraseña.Text);
               
            }
            else
            {
                lbl_Error.Visible = true;
            }
        }

        public void MostrarInformacion(bool InicioCorrecto)
        {
            if (InicioCorrecto)
            {
                lbl_Error.Visible= true;
                lbl_Error.Text = Res.Existe;
            }
            else
            {
                DialogResult = DialogResult.OK;
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
