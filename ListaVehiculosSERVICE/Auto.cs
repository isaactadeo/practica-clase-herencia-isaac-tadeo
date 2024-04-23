using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVehiculosSERVICE
{
    public class Auto : Vehiculo
    {
        public int CantPuertas { get; set; }

        public override string Caracteristicas()
        {
            return base.Caracteristicas() + " un Auto de " + CantPuertas + " puertas";
        }


    }
}
