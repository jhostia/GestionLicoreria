using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestorUsuarios
    {
        private readonly UsuarioRepository _datosUsuarios;

        public GestorUsuarios()
        {
            _datosUsuarios = new UsuarioRepository();
        }

        public void GuardarUsuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.NombreUsuario) || string.IsNullOrEmpty(usuario.CorreoElectronico) || string.IsNullOrEmpty(usuario.Contrasena))
            {
                throw new ArgumentException("Por favor complete todos los campos.");
            }

            if (UsuarioExiste(usuario.NombreUsuario))
            {
                throw new ArgumentException("El usuario ya existe. Por favor elija otro nombre de usuario.");
            }

            _datosUsuarios.GuardarUsuario(usuario);
        }

        public bool UsuarioExiste(string nombreUsuario)
        {
            List<Usuario> usuarios = _datosUsuarios.ObtenerUsuarios();
            return usuarios.Any(u => u.NombreUsuario == nombreUsuario);
        }

        public Usuario IniciarSesion(string nombreUsuario, string contrasena)
        {
            Usuario usuario = _datosUsuarios.ObtenerUsuarios().FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contrasena == contrasena);

            if (usuario == null)
            {
                throw new ArgumentException("Nombre de usuario o contraseña incorrectos.");
            }

            return usuario;
        }
    }
}
