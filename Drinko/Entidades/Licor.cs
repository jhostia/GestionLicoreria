using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Licor
    {
        public Licor() { }

        public Licor(string marca, double precio, int grado, string sabor)
        {
            Marca = marca;
            Precio = precio;
            Grado = grado;
            Sabor = sabor;
        }
        public override string ToString()
        {
            return $"{Marca};{Precio};{Grado};{Sabor}";
        }
        //public string TipoLicor { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int Grado { get; set; }
        public string Sabor { get; set; }
        //public Fecha { get; set; }




        //public Licor(int id, string nombreLicor, string descripcion, decimal precio, int cantidadStock)
        //{
        //    Id = id;
        //    NombreLicor = nombreLicor;
        //    Descripcion = descripcion;
        //    Precio = precio;
        //    CantidadStock = cantidadStock;
        //}

        //public override string ToString()
        //{
        //    return $"{Id},{NombreLicor},{Descripcion},{Precio},{CantidadStock}";
        //}

        //public int Id { get; set; }
        //public string NombreLicor { get; set; }
        //public string Descripcion { get; set; }
        //public decimal Precio { get; set; }
        //public int CantidadStock { get; set; }
    }
}
