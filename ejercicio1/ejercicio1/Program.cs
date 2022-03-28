using System;
using LogicaNegocio;
namespace ejercicio1
{
    class Program
    {
        static float temperaturaCelsius;
        static float temperaturaKelvin;

        static void Main(string[] args)
        {
            temperaturaCelsius = 30;
            temperaturaKelvin = ConversorDeTemperatura.ConversorDeCelsiusAKelvin(temperaturaCelsius);

            mostrarTemperaturas();

        }

        static void mostrarTemperaturas()
        {
            Console.WriteLine($"La temperatura Celsius es: {temperaturaCelsius}");
            Console.WriteLine($"La temperatura Kelvin es: {temperaturaKelvin}");

        }
    }
}
