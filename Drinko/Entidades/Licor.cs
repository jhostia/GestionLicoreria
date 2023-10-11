using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Licor
    {
        public Licor()
        {
        }

        public Licor(int id, string nombreLicor, string descripcion, decimal precio, int cantidadStock)
        {
            Id = id;
            NombreLicor = nombreLicor;
            Descripcion = descripcion;
            Precio = precio;
            CantidadStock = cantidadStock;
        }

        public override string ToString()
        {
            return $"{Id},{NombreLicor},{Descripcion},{Precio},{CantidadStock}";
        }

        public int Id { get; set; }
        public string NombreLicor { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int CantidadStock { get; set; }
    }
}
