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
        //T Value;
        public void DevolverPartidas<U>(U obj) where U : IMenu
        {
            obj.MostrarDatos(ConexionBd.ObtenerDatosPartida());
        }

        public void DevolverUsuarios<U>(U obj) where U : IMenu
        {
            obj.MostrarDatos(ConexionBd.ObtenerUsuarios());
        }


        public void Revisar <U> (U obj, Jugador jugador) where U : IPartida
        {
            obj.DevolverTiradas(jugador.del);
        }
        
        public void ConseguirUltimoId <U> (U obj) where U : IPartida
        {
            obj.ConseguirUltimoId(ConexionBd.ObtenerUltimoId());
        }
    }
    
   
}
