using System;
namespace helloworld
{
	class Program
	{
		static void Main(string[]args)
		{
            Auto auto1= new Auto();
            auto1.color="negro";
            auto1.marca="fiat";
            auto1.pasajeros=2;
            auto1.Encender();

            Restaurante rest1=new Restaurante();
            rest1.cantMozos=10;
            rest1.direccion="Sarmiento 700";
            rest1.mesas= 20;
            rest1.Cocinar();
		}
        public class Auto
        {
            public string color;
            public string marca;
            public int pasajeros;

            public void Encender()
            {
                Console.WriteLine("El auto esta encendido");
            }
            public void AbrirPuerta()
            {
                Console.WriteLine("La puerta esta abrierta");
            }
        }
        public class Restaurante
        {
            public int mesas;
            public string direccion;
            public int cantMozos;
            public void Cocinar()
            {
                Console.WriteLine("Se esta empezando a cocinar");
            }
            public void Emplatar()
            {
                Console.WriteLine("Se esta emplatando el plato");
            }
        }
	}
}