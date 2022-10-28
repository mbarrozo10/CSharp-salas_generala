using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad.clases
{
    public class Usuario
    {
        public int id;
        private string? nombre;
        private string? apellido;
        private string user;
        private string contraseña;

        public Usuario(string nombre, string apellido, string usuario, string contraseña, int id) : this(usuario, contraseña)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
        }

        public Usuario(string usuario, string contraseña)
        {
            user = usuario;
            this.contraseña = contraseña;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string User { get => user; set => user = value; }
        public string? Apellido { get => apellido; set => apellido = value; }

        public bool ComprobarInicio()
        {
            List<Usuario> usuarios = ConexionBd.ObtenerUsuarios();
            foreach (Usuario usuarioBd in usuarios)
            {
                if (User == usuarioBd.User && contraseña == usuarioBd.contraseña)
                {
                    nombre = usuarioBd.nombre;
                    apellido = usuarioBd.apellido;
                    return true;
                }
            }
            return false;
        }
    }
}
