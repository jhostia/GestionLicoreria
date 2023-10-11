using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LicorServicio
    {
        LicorRepository licorRepository = null;
        private List<Licor> licorList = null;
        public LicorServicio()
        {
            licorRepository = new LicorRepository();
        }
        
        public string GuardarLicor (Licor licor)
        {

            return "";
        }


    }
}
