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

        public VentanaRegistrarLicor()
        {
            InitializeComponent();
        }

        private void btnGuardarL_Click(object sender, EventArgs e)
        {
            Licor licor = new Licor();
            string tipoLicor = "";
            licor.Marca = tipoLicor;
            licor.Marca = txtMarca.Text.Trim();
            licor.Precio = double.Parse(txtPrecio.Text.Trim());
            licor.Grado = int.Parse(txtGrado.Text.Trim());
            licor.Sabor = txtSabor.Text.Trim();
            Guardar(licor);
            LimpiarCasillas();
        }
        void Guardar(Licor licor)
        {
            var msg = licorService.Guardar(licor);
            MessageBox.Show(msg);
        }
        void LimpiarCasillas()
        {
            txtMarca.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtGrado.Text = string.Empty;
            txtSabor.Text = string.Empty;
            txtFecha.Text = string.Empty;
            //cheContributivo.Checked = false;

        }
    }
}
