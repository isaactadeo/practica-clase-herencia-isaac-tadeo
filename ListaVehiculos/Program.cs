// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ListaVehiculosSERVICE;


ListaVehiculo ListaVehiculo = new ListaVehiculo();

Console.WriteLine("Ingresar un vehiculo (s/n)");
string ingreso = Console.ReadLine();

while (ingreso.ToLower()== "s") {
    Console.WriteLine("Ingrese Marca del vehiculo");
    string marca = Console.ReadLine();

    Console.WriteLine("Ingrese Modelo del vehiculo");
    string modelo = Console.ReadLine();
    
    Console.WriteLine("Ingrese Año del vehiculo");
    int año = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el tipo del Vehiculo: Auto o Camioneta (a/c)");
    string tipo = Console.ReadLine();

    if (tipo.ToLower() == "a")
    {
        Console.WriteLine("Ingrese Cantidad de puertas del Auto");
        int cpuertas = int.Parse(Console.ReadLine());

        Auto auto = new Auto();
        auto.Marca = marca;
        auto.Modelo = modelo;
        auto.Año = año;
       auto.CantPuertas = cpuertas;
        
        ListaVehiculo.NuevoVehiculo(auto);
        
        string caracteristicas = auto.Caracteristicas();
        Console.WriteLine(caracteristicas);
    } else if (tipo.ToLower() == "c") {

        Console.WriteLine("Ingrese la traccion de la camioneta");
        string traccion = Console.ReadLine();

        Camioneta camioneta = new Camioneta();
        camioneta.Marca = marca;
        camioneta.Modelo = modelo;
        camioneta.Año = año;
        camioneta.Traccion = traccion;

        ListaVehiculo.NuevoVehiculo(camioneta);

        string caracteristicas = camioneta.Caracteristicas();
        Console.WriteLine(caracteristicas);
    } else {
        Console.WriteLine("Vehiculo no reconocido");
    }
    
   


    Console.WriteLine("¿Desea ingresar otro vehiculo? (s/n)");
 ingreso = Console.ReadLine();

}

//si quisiera agregar los vehiculos como dice el ejercicio

Auto auto1 = new Auto();
auto1.Marca = "Nissan";
auto1.Modelo = "Skyline";
auto1.Año = 1995;
auto1.CantPuertas = 4;
ListaVehiculo.NuevoVehiculo(auto1);


Auto auto2 = new Auto();
auto2.Marca = "Porsche";
auto2.Modelo = "Carrera GT";
auto2.Año = 2011;
auto2.CantPuertas = 2;
ListaVehiculo.NuevoVehiculo(auto2);

Camioneta camioneta1 = new Camioneta();
camioneta1.Marca = "Toyota";
camioneta1.Modelo = "Hilux";
camioneta1.Año = 2020;
camioneta1.Traccion = "4x4";
ListaVehiculo.NuevoVehiculo(camioneta1);

foreach (var auto in ListaVehiculo.Vehiculos)
{
    string caracteristicas = auto.Caracteristicas();
    Console.WriteLine(caracteristicas);
}



