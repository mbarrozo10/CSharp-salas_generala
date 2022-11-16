using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad.clases
{
    public class Estadisticas
    {
        int cantidadPartidasJugadas;
        List<Usuario> usuarios;
        int cantidadPartidasEmpatadas;
        int cantidadPartidasCanceladas;
        int cantidadPartidasFinalizadas;

        public Estadisticas(int cantidadPartidasJugadas, List<Usuario> usuarios, int cantidadPartidasEmpatadas, int cantidadPartidasCanceladas, int cantidadPartidasFinalizadas)
        {
            this.cantidadPartidasJugadas = cantidadPartidasJugadas;
            this.usuarios = usuarios;
            this.cantidadPartidasEmpatadas = cantidadPartidasEmpatadas;
            this.cantidadPartidasCanceladas = cantidadPartidasCanceladas;
            this.cantidadPartidasFinalizadas = cantidadPartidasFinalizadas;
        }

        public int CantidadPartidasJugadas { get => cantidadPartidasJugadas; set => cantidadPartidasJugadas = value; }
        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        public int CantidadPartidasEmpatadas { get => cantidadPartidasEmpatadas; set => cantidadPartidasEmpatadas = value; }
        public int CantidadPartidasCanceladas { get => cantidadPartidasCanceladas; set => cantidadPartidasCanceladas = value; }
        public int CantidadPartidasFinalizadas { get => cantidadPartidasFinalizadas; set => cantidadPartidasFinalizadas = value; }
    }
}
