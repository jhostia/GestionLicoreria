using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GestorUsuarios
    {
        private UsuarioRepository usuarioRepository; // Instancia de la capa de datos

        public GestorUsuarios()
        {
            usuarioRepository = new UsuarioRepository(); // Inicializa la instancia de la capa de datos
        }

        public bool IniciarSesion(string nombreUsuario, string contraseña)
        {
            // Verificar si las credenciales son válidas utilizando la capa de datos
            bool credencialesValidas = usuarioRepository.ValidarCredenciales(nombreUsuario, contraseña);

            if (credencialesValidas)
            {
                // Las credenciales son válidas, permitir el inicio de sesión
                return true;
            }
            else
            {
                // Las credenciales son incorrectas, mostrar un mensaje de error
                return false;
            }
        }
    }
}
