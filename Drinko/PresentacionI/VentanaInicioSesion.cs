using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionI
{
    public partial class VentanaInicioSesion : Form
    {

        public VentanaInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos ingresados por el usuario en la interfaz
                string nombreUsuario = txtUsuario.Text;
                string contrasena = txtContraseña.Text;

                // Iniciar sesión usando la capa de lógica
                GestorUsuarios logicaUsuarios = new GestorUsuarios();
                Usuario usuario = logicaUsuarios.IniciarSesion(nombreUsuario, contrasena);
                MessageBox.Show($"Bienvenido, {usuario.NombreUsuario}.");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}");
 
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un objeto Usuario con los datos ingresados por el usuario en la interfaz
                Usuario usuario = new Usuario
                {
                    NombreUsuario = txtReUsuario.Text,
                    CorreoElectronico = txtReCorreo.Text,
                    Contrasena = txtReContra.Text
                };

                // Guardar el usuario usando la capa de lógica
                GestorUsuarios logicaUsuarios = new GestorUsuarios();
                logicaUsuarios.GuardarUsuario(usuario);

                MessageBox.Show("Usuario registrado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}");
            }

            pnlRegistrar.Visible = false;
            pnlIniciar.Visible = true;
        }
        private void btnRegiInicio_Click(object sender, EventArgs e)
        {
            pnlRegistrar.Visible = true;
            pnlIniciar.Visible = false;
        }
    }
}
