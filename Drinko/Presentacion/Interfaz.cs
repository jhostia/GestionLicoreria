using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    internal class Interfaz
    {
        private GestorUsuarios gestorUsuarios;

        public Interfaz()
        {
            gestorUsuarios = new GestorUsuarios();
        }

        static void Main(string[] args)
        {
            Interfaz interfaz = new Interfaz();
            interfaz.Ejecutar();
        }

        public  void Ejecutar()
        {
            bool sesionIniciada = false;
            string nombreUsuario = string.Empty;

            while (!sesionIniciada)
            {
                Console.WriteLine("=== Aplicación de Gestión de Licorería ===");
                Console.WriteLine();

                Console.Write("Ingrese el nombre de usuario: ");
                string inputUsuario = Console.ReadLine();

                Console.Write("Ingrese la contraseña: ");
                string inputContraseña = Console.ReadLine();

                // Llamada al método de la capa de lógica para iniciar sesión
                bool inicioSesionExitoso = gestorUsuarios.IniciarSesion(inputUsuario, inputContraseña);

                if (inicioSesionExitoso)
                {
                    sesionIniciada = true;
                    nombreUsuario = inputUsuario;
                }
                else
                {
                    Console.WriteLine("Inicio de sesión fallido. Inténtelo de nuevo.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Sesión iniciada como {nombreUsuario}.");
        }
    }
}

