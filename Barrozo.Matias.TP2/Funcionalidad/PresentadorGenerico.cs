using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public class PresentadorGenerico<T> 
    {
        private T dato;
        public T Dato{
            get { return dato; }
        }
        public List<Partida> DevolverPartidas<T>(T obj) where T : IPartida
        {
            return ConexionBd.ObtenerDatosPartida();
        }


    }
}
