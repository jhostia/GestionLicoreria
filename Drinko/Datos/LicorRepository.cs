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
        public string FileName = "licor.txt";

        public string Guardar(Licor licor)
        {
            var escritor = new StreamWriter(FileName, true);
            escritor.WriteLine(licor.ToString());
            escritor.Close();
            return "Licor guardada con éxito";
        }
        public List<Licor> ConsultarTodos()
        {
            var licores = new List<Licor>();

            if (!File.Exists(FileName))
            {
                return licores;
            }
            else
            {
                var lector = new StreamReader(FileName);

                while (!lector.EndOfStream)
                {
                    licores.Add(Mapeo(lector.ReadLine()));
                }

                lector.Close();
                return licores;
            }
        }
        private Licor Mapeo(string linea)
        {
            var licor = new Licor();
            //licor.TipoLicor = linea.Split(',')[0];
            licor.Marca = linea.Split(';')[0];
            licor.Precio = double.Parse(linea.Split(';')[1]);
            licor.Grado = int.Parse(linea.Split(';')[2]);
            licor.Sabor = linea.Split(';')[3];

            return licor;
        }
    }
}
