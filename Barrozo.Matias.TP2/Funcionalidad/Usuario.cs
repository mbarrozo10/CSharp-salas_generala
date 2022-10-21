using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public class Usuario
    {
        private string? nombre;
        private string? apellido;
        private string user;
        private string contraseña;

        public Usuario(string nombre, string apellido, string usuario, string contraseña): this (usuario,contraseña)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        
        public Usuario(string usuario, string contraseña)
        {
            this.user = usuario;
            this.contraseña = contraseña;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string User { get => user; set => user = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }


        public bool ComprobarInicio()
        {
             List<Usuario> usuarios = ConexionBd.ObtenerDatos();
            foreach(Usuario usuarioBd in usuarios)
            {
                if(this.User == usuarioBd.User && this.Contraseña == usuarioBd.contraseña)
                {
                    this.nombre = usuarioBd.nombre;
                    this.apellido = usuarioBd.apellido;
                    return true;
                }
            }    
            return false;
        }
    }
}
