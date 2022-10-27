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
       
        public void DevolverPartidas<T>(T obj) where T : IMostradorPartidas
        {
            obj.MostrarDatos(ConexionBd.ObtenerDatosPartida());
        }
        
        public void DevolverJugadores<T>(T obj) where T : IMostradorJugador
        {
            obj.MostrarDatos(ConexionBd.ObtenerJugadores());
        }
    }
    
   
}
