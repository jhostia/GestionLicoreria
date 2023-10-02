using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioRepository
    {
        public string Filename = "Usuarios.txt";

        public List<Usuario> CargarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>(); // Declaración e instancia de la lista

            // Aquí, se carga la información de usuarios desde el archivo de texto y se agrega a la lista
            string[] lineas = File.ReadAllLines(Filename);

            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(',');
                if (campos.Length == 3)
                {
                    string nombreUsuario = campos[0];
                    string contraseña = campos[1];
                    string rol = campos[2];

                    Usuario usuario = new Usuario(nombreUsuario, contraseña, rol);
                    usuarios.Add(usuario); // Agrega el usuario a la lista
                }
            }

            return usuarios; // Devuelve la lista de usuarios cargada desde el archivo
        }

        public bool ValidarCredenciales(string nombreUsuario, string contraseña)
        {
            List<Usuario> usuarios = CargarUsuarios(); // Cargar la lista de usuarios desde el archivo

            foreach (Usuario usuario in usuarios)
            {
                // Compara el nombre de usuario y la contraseña ingresados con los datos en la lista
                if (usuario.NombreUsuario == nombreUsuario && usuario.Contraseña == contraseña)
                {
                    return true; // Si las credenciales son válidas, devuelve true
                }
            }

            return false; // Si no se encontraron credenciales válidas, devuelve false
        }
    }
}
