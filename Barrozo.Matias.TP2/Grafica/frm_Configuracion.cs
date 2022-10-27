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
          config   = new Configuracion();
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Funcionalidad.Serializazdor<Configuracion>.EscribirJSON(this.config, "config");
            DialogResult = DialogResult.OK;
        }
    }
}
