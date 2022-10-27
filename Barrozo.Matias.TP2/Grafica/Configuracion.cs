using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafica
{
    public class Configuracion
    {
        string idioma;
        //Color fondo;
        //Color colorSecundario;
        int[] fondo;
        int[] colorSecundario;
        int[] foreColor;

        public Configuracion()
        {
       
        }

        public string Idioma { get => idioma; set => idioma = value; }
        //public Color Fondo { get => fondo; set => fondo = value; }
        //public Color ColorSecundario { get => colorSecundario; set => colorSecundario = value; }


        public int[] Fondo { get => fondo; set => fondo = value; }
        public int[] ColorSecundario { get => colorSecundario; set => colorSecundario = value; }
        public int[] ForeColor { get => foreColor; set => foreColor = value; }
    }
}
