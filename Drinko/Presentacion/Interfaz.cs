using Entidades;
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
        private LicorServicio licorServicio = new LicorServicio();

        public Interfaz()
        {
            gestorUsuarios = new GestorUsuarios();
        }

        static void Main(string[] args)
        {
            Interfaz interfaz = new Interfaz();
            //interfaz.Ejecutar();
            interfaz.GestionLicor();
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

            if (sesionIniciada == true)
            {
                Console.Clear();
                GestionLicor();
            }
        }
        //*************************************************************************
        //Menu licor 
        public void GestionLicor()
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(15, 2); Console.WriteLine("########### Gestion Licor ############");
                Console.SetCursorPosition(10, 5); Console.WriteLine("1. Agregar Licor");
                Console.SetCursorPosition(10, 7); Console.WriteLine("2. Mostrar todos los licores registrados");
                Console.SetCursorPosition(10, 9); Console.WriteLine("3. Actualizar licor");
                Console.SetCursorPosition(10, 11); Console.WriteLine("4. Eliminar licor");
                Console.SetCursorPosition(10, 13); Console.WriteLine("5. Salir del programa");
                Console.SetCursorPosition(15, 15); Console.WriteLine("Seleccione una opcion");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Guardarlicor();
                        break;
                    case 2:
                        //MostrarPersona();
                        break;
                    case 3:
                        //Sistema de punto de venta POV
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }

            } while (op != 5);
        }
        public void Guardarlicor()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el id del licor");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el nombre del licor");
            string nombrelicor = Console.ReadLine();
            Console.WriteLine("Digite la descripción");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Digite el precio del licor");
            decimal precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese ella cantidad stock de licor");
            int cantidadStok= int.Parse(Console.ReadLine());

            Licor licor = new Licor(id, nombrelicor, descripcion, precio, cantidadStok);
            Console.WriteLine(licorServicio.Guardado(licor));
            Console.ReadKey();
        }
    }
}

        