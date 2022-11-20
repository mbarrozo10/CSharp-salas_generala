using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public class PresentadorLogin
    {
        ILogin obj;
        public PresentadorLogin(ILogin login)
        {
            obj = login;
        }
        public void ComprobarLogin(Usuario usuario)
        {
            obj.ComprobarInicio(usuario.ComprobarInicio());
        }
    }
}
