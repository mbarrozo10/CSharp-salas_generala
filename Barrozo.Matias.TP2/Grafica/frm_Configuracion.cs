using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funcionalidad.clases;

namespace Grafica
{
    public partial class frm_Configuracion : Form
    {
        Configuracion config;
        public frm_Configuracion()
        {
            InitializeComponent();
        }
        
        public frm_Configuracion(Configuracion config):this()
        {
            this.config = config;
        }

        private void frm_Configuracion_Load(object sender, EventArgs e)
        {
            CargarColor();
            CargarIdioma();
        }

        private void rdb_Claro_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton radio)
            {
                switch (radio.Name)
                {
                    case "rdb_Claro":
                        config.Fondo = new int[3] {255,255,255};
                        config.ColorSecundario = new int[3] { 34, 34, 54 };
                        config.ForeColor = new int[3] { 34, 34, 34 };
                        break;
                    case "rdb_Oscuro":
                        config.Fondo = new int[3] { 34, 34, 34 };
                        config.ColorSecundario = new int[3] { 34, 34, 54 };
                        config.ForeColor = new int[3] { 255, 255, 255 };
                        //config.Fondo = Color.FromArgb(34,34,34);
                        //config.ColorSecundario = Color.FromArgb(34, 34, 54);
                        break;
                    case "rdb_Inverso":
                        config.Fondo = new int[3] { 34, 34, 54 };
                        config.ColorSecundario = new int[3] { 34, 34, 34 };
                        config.ForeColor = new int[3] { 255, 255, 255 };

                        //config.Fondo = Color.FromArgb(34,34,54);
                        //config.ColorSecundario = Color.FromArgb(34, 34, 34);
                        break;
                    case null:
                        break;

                }
            }
        }

        private void rdb_Español_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
            {
                switch (radio.Name)
                {
                    case "rdb_Español":
                        config.Idioma = "";
                        break;
                    case "rdb_Ingles":
                        config.Idioma = "en-US";
                        break;
                    case "rdb_Japones":
                        config.Idioma = "ja";
                        break;
                    case "rdb_Portugues":
                        config.Idioma = "pl";
                        break;
                    case null:
                        break;

                }
            }
        }

        void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(config.Idioma);
            grp_Color.Text = Res.Color;
            grp_Idioma.Text = Res.Idioma;
            rdb_Claro.Text = Res.Claro;
            rdb_Español.Text = Res.Español;
            rdb_Ingles.Text = Res.Ingles;
            rdb_Inverso.Text = Res.Inverso;
            rdb_Japones.Text = Res.Japones;
            rdb_Oscuro.Text = Res.Oscuro;
            rdb_Portugues.Text = Res.Portugues;
            btn_Guardar.Text = Res.Guardar;
        }

        void CargarColor()
        {
            this.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            btn_Guardar.BackColor = Color.FromArgb(config.Fondo[0], config.Fondo[1], config.Fondo[2]);
            grp_Color.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            grp_Idioma.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            rdb_Claro.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            rdb_Español.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            rdb_Ingles.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            rdb_Japones.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            rdb_Oscuro.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            rdb_Portugues.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            btn_Guardar.ForeColor = Color.FromArgb(config.ForeColor[0], config.ForeColor[1], config.ForeColor[2]);
            
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Serializazdor<Configuracion>.EscribirJSON(this.config, "config");
            DialogResult = DialogResult.OK;
        }
    }
}
