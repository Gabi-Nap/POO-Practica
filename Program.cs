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
	}
}