using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LicorRepository
    {
        string fileName = "Licor.txt";

        public string GuardarLicor(Licor licor)
        {
            var escritor = new StreamWriter(fileName, true);
            escritor.WriteLine(licor.ToString());
            escritor.Close();
            return $"El producto {licor.NombreLicor} Fue guardado correctamente";
        }
    }
}
