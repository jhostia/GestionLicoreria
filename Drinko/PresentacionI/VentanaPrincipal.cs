using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionI
{
    public partial class VentanaPrincipal : Form
    {
        // Agrega una propiedad para rastrear el estado de inicio de sesión
        //public bool UsuarioHaIniciadoSesion { get; set; } = false;

        public VentanaPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            // Deshabilitar botones al inicio
            //btnAgregar.Enabled = false;
            //btnConsultaree.Enabled = false;

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Es para que pueda mover la ventana a voluntad 
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void sendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            sendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // Fin mover ventana 


        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

                AbrirFormHija(new VentanaRegistrarLicor());
 
   
        }

        private void btnConsultaree_Click(object sender, EventArgs e)
        {

                AbrirFormHija(new VentanaConsultar());
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new VentanaInicioSesion());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
