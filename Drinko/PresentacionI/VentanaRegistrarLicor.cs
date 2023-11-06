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
    public partial class VentanaRegistrarLicor : Form
    {
        private LicorServicio licorService = new LicorServicio();
        int fila;

        public VentanaRegistrarLicor()
        {
            InitializeComponent();
            ActualizarListBox();
        }

        private void btnGuardarL_Click(object sender, EventArgs e)
        {
            Licor licor = new Licor();
            string tipoLicor = "";

            int indiceSeleccionado = comboBoxTipo.SelectedIndex;
            // Realiza acciones basadas en la opción seleccionada
            switch (indiceSeleccionado)
            {
                case 0:
                    tipoLicor = "Ron";
                    break;
                case 1:
                    tipoLicor = "Vino";
                    break;
                case 2:
                    tipoLicor = "Vodka";
                    break;
                case 3:
                    tipoLicor = "Tequila";
                    break;
                case 4:
                    tipoLicor = "Whisky";
                    break;
                case 5:
                    tipoLicor = "Cerveza";
                    break;
                case 6:

                    break;
            }
            licor.TipoLicor = tipoLicor;
            licor.Marca = txtMarca.Text.Trim();
            licor.Precio = double.Parse(txtPrecio.Text.Trim());
            licor.Grado = double.Parse(txtGrado.Text.Trim());
            licor.Sabor = txtSabor.Text.Trim();
            licor.Fecha = dttFecha.Value;

            Guardar(licor);
            LimpiarCasillas();
            ActualizarListBox();
        }
        void Guardar(Licor licor)
        {
            var msg = licorService.Guardar(licor);
            MessageBox.Show(msg);
        }
        void LimpiarCasillas()
        {
            comboBoxTipo.SelectedIndex = 6;
            txtMarca.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtGrado.Text = string.Empty;
            txtSabor.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
        private void Listadogeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void ActualizarListBox()
        {
            listadoGeneral.Items.Clear(); // Borra los elementos anteriores
            // Obtiene la lista de licores del servicio
            var licores = licorService.ConsultarTodos();
            // Agrega cada licor al ListBox
            foreach (var licor in licores)
            {
                listadoGeneral.Items.Add(licor.ToString());
            }
        }
    }
}