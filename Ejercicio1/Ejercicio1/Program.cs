using System;
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[]args)
        {
            Vehiculo v1= new Vehiculo();
            v1.capacidad=30;
            v1.cantPuertas=3;
            v1.cantAsientos=20;
            v1.Arrancar();
            Autobus bus1=new Autobus();
            bus1.empresa="dota";
            bus1.CargaPasajeros();
        }
        public class Vehiculo
        {
            public int capacidad;
            public int cantPuertas;
            public int cantAsientos;
            public void Arrancar()
            {
                Console.WriteLine("El vehiculo esta arrancando");
            }
            public void Detener()
            {
                Console.WriteLine("El vehiculo se esta deteniendo");
            }
            public void Frenar()
            {
                Console.WriteLine("El vehiculo esta frenando");
            }
            public void Acelerar()
            {
                Console.WriteLine("El vehiculo esta acelerando");
            }

        }
        public class Autobus:Vehiculo
        {
            public string empresa;
            public void CargaPasajeros()
            {
                Console.WriteLine("pasajeros ascendiendo");
            }
            public void DescargaPasajeros()
            {
                Console.WriteLine("pasajeros descendiendo");
            }
        }
    }
}