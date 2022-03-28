using System;
//Ingresar un número y mostrar el cuadrado y el cubo del mismo.
//Se debe validar que el número sea mayor que cero, caso contrario,
//mostrar el mensaje: "ERROR. ¡Reingresar número!".

namespace Clase1Ejercicio2
{
    class Program
    {
        private static double numero;
        private static double cubo;
        private static double cuadrado;
        static void Main(string[] args)
        {

            Console.WriteLine("!ingresar número!");
            if (double.TryParse(Console.ReadLine(),out numero) && numero > 0)
            {
                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.WriteLine($"el numero ingresado es: {numero} , su cuadrado es: {cuadrado} y su cubo es: {cubo}");

            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

           
              
        }

    }
}
