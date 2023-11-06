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
        //private string fileName = "licor.txt";
        LicorRepository licorRepository = null;
        private List<Licor> licorList = null;
        public LicorServicio()
        {
            licorRepository = new LicorRepository();
            licorList = licorRepository.ConsultarTodos();
        }
        public string Guardar(Licor licor)
        {
            if (licor == null)
            {
                return "No se puede guardar una liquidacion nula o sin informacion";
            }
            else
            {
                var mensaje = licorRepository.Guardar(licor);
                licorList = licorRepository.ConsultarTodos();
                return mensaje;
            }
        }
        public List<Licor> ConsultarTodos()
        {
            return licorList;
        }

    }
}
