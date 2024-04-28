using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListaVehiculosSERVICE
{
    public class ListaVehiculo
    {

        public List<Vehiculo> Vehiculos { get; set; }

        public List<Auto> Autos { get; set; }

        public List<Camioneta> Camionetas { get; set; }

        public ListaVehiculo()
        {
            Vehiculos = new List<Vehiculo>();
            Autos = new List<Auto>();
            Camionetas = new List<Camioneta>();

           
        }

        public bool NuevoVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo); 

            return true;
        }

        //CORRECCION: FALTA UN METODO PARA DEVOLVER LA LISTA

    }



}


  