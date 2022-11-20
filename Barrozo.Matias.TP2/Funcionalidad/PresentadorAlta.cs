using Funcionalidad.clases;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public class PresentadorAlta
    {
        IAlta obj;
        static ConexionBdUsuarios conexionBdUsuarios;

        public PresentadorAlta(IAlta alta)
        {
            conexionBdUsuarios = new ConexionBdUsuarios();
            obj = alta;
        }
        public void AgregarUsuario(string nombre, string apellido, string user, string contraseña)
        {
            bool existe = VerificarUsuario(user); ;
            if (!existe)
            {
                Usuario usuario = new Usuario(nombre, apellido, user);
                conexionBdUsuarios.GuardarUsuarios(usuario, contraseña);

            }
            obj.MostrarInformacion(existe);

        }

        private bool VerificarUsuario(string user)
        {
            List<Usuario> usuarios= conexionBdUsuarios.ObtenerUsuarios();
            foreach(Usuario usuario in usuarios)
            {
                if(usuario.User == user)
                {
                    return true; ;
                }
            }
            return false;
        }
    }
}
