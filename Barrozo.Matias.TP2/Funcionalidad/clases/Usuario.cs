using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad.clases
{
    public enum EEstado
    {
        jugando,libre
    }
    public class Usuario
    {
        private int id;
        private string? nombre;
        private string? apellido;
        private string user;
        private string contraseña;
        int partiasGanadas;
        private EEstado estado;

        public Usuario(string nombre, string apellido, string usuario, string contraseña, int id, EEstado estado, int partiasGanadas) : this(usuario, contraseña)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
            this.estado = estado;
            this.partiasGanadas = partiasGanadas;
        }

        public Usuario(string usuario, string contraseña)
        {
            user = usuario;
            this.contraseña = contraseña;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string User { get => user; set => user = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public EEstado Estado { get => estado; set => estado = value; }
        public int PartiasGanadas { get => partiasGanadas; set => partiasGanadas = value; }

        public bool ComprobarInicio()
        {
            ConexionBdUsuarios conexion = new ConexionBdUsuarios();
            List<Usuario> usuarios = conexion.ObtenerUsuarios();
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
