using System;
//Ingresar 5 números por consola, guardándolos en una variable escalar.
//Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio
namespace Vista
{
    class Program
    {
        private static int numero;
        private static int i;
        private static int minimo;
        private static int maximo;

        static void Main(string[] args)
        {
            maximo = int.MinValue;
            minimo = int.MaxValue;

            for (i = 0; i < 5; i++)
            {
                Console.Write($"ingrese un numero {i}: ");
                if (int.TryParse(Console.ReadLine(),out numero))
                {
                    if(numero > maximo)
                    {
                        maximo = numero;
                    }

                    if (numero < minimo)
                    {
                        minimo = numero;
                    }

                }
                else
                {
                    Console.WriteLine("error ingrese numeros por favor!!!");
                }

            }

            Console.WriteLine($"el maximo es: {maximo} y el minimo es: {minimo}");



        }
    }
}
