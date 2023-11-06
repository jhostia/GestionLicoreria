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

        public Licor(string tipoLicor, string marca, double precio, double grado, string sabor, DateTime fecha)
        {
            TipoLicor = tipoLicor;
            Marca = marca;
            Precio = precio;
            Grado = grado;
            Sabor = sabor;
            Fecha = fecha;
        }
        public override string ToString()
        {
            return $"{TipoLicor};{Marca};{Precio};{Grado};{Sabor};{Fecha:yyyy-MM-dd}";
        }
        public DateTime Fecha { get; set; }
        public string TipoLicor { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public double Grado { get; set; }
        public string Sabor { get; set; }
        //public Fecha { get; set; }

    }
}
