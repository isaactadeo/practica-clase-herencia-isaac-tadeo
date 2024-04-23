using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVehiculosSERVICE
{
    public class Camioneta : Vehiculo
    {
        public string Traccion { get; set; }

        public override string Caracteristicas()
        {
            return base.Caracteristicas() + " una Camioneta de traccion " + Traccion;
        }


    }


}
