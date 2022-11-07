using Funcionalidad;
using Funcionalidad.clases;

namespace Grafica
{
    public partial class frm_Login : Form, ILogin
    {
        PresentadorGenerico presentador;
        Configuracion config;
        public frm_Login()
        {
            InitializeComponent();

        }

        public void ComprobarInicio(bool ok)
        {
            if (ok)
            {
                frm_MenuPrincipal principal = new frm_MenuPrincipal(config);
                this.Hide();
                if (principal.ShowDialog() == DialogResult.Cancel)
                {
                    lbl_Error.Visible = false;
                    txt_Usuario.Clear();
                    txt_Contraseña.Clear();
                    this.Show();
                    CambiarIdioma();
                    CambiarColor();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_Usuario.Text!= string.Empty && txt_Contraseña.Text != string.Empty)
            {
                Usuario user = new Usuario(txt_Usuario.Text, txt_Contraseña.Text);
                presentador.ComprobarLogin(user, this);
            }else
            {
                lbl_Error.Visible = true;
            }

        }

        void CambiarIdioma()
        {
            config = Serializazdor<Configuracion>.LeerJSON("config");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(config.Idioma);
            lbl_Error.Text = Res.ErrorLogin;
            lbl_Login.Text = Res.Inicio;
            btn_Login.Text = Res.Inicio;
            btn_Salir.Text = Res.Salir;
        }

        void CambiarColor()
        {
            this.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            txt_Contraseña.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            txt_Usuario.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            //btn_Login.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);

            btn_Login.BackColor= Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            btn_Salir.BackColor= Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            pnl_MenuPrincipal.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            pnl_Superior.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            txt_Contraseña.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);
            txt_Usuario.BackColor = Color.FromArgb(config.ColorSecundario[0], config.ColorSecundario[1], config.ColorSecundario[2]);


        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            presentador = new PresentadorGenerico();
            config = new Configuracion();
            CambiarIdioma();
            CambiarColor();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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