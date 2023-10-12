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
        
        public string Guardado (Licor licor)
        {
            //Este condiconal valida que el dato que se vaya a guardar no sea nulo o este vacia la informacion 
            if (licor == null)
            {
                return "No se puede agregar informacion nulas o sin in formacion";
            }
            //Si el dato no es nulo en tonces mandara la informacion al metodo guardar de ñla capa de datos y
            //guardara la informacion en el archivo de texto
            var msg = (licorRepository.GuardarLicor(licor));
            return msg;
        }


    }
}
