using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVehiculosSERVICE
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        public virtual string Caracteristicas()
        {
            return "El Vehiculo " + Marca  +  Modelo + " del año " + Año + " es:";
        }

    }

}
