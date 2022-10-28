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
        
        public void DevolverUsuarios<T>(T obj) where T : IMostradorUsuarios
        {
            obj.MostrarDatos(ConexionBd.ObtenerUsuarios());
        }


        public void Revisar <T> (T obj, Jugador jugador) where T: IPartida
        {
            obj.DevolverTiradas(jugador.del);
        }
        
        public void ConseguirUltimoId <T> (T obj) where T: IPartida
        {
            obj.ConseguirUltimoId(ConexionBd.ObtenerUltimoId());
        }
    }
    
   
}
