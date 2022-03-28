using System;
/*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

IMPORTANTE*/

namespace Vista
{
    class Program
    {
        private static int numero;
        private static int i;
        private static int contadorDePrimos;
        private static string respuesta;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("ingrese un numero mayor a 1: ");
                if (int.TryParse(Console.ReadLine(), out numero)&& numero > 1)
                {
                    contadorDePrimos = 0;
                    for(i = numero; i> 0; i--)
                    {
                        if(numero % i==0)
                        {
                            contadorDePrimos++;
                        }
                    }

                    if(contadorDePrimos >2)
                    {
                        Console.WriteLine("no es primo");
                    }
                    else
                    {
                        Console.WriteLine("es primo");
                    }

                    Console.WriteLine("si no desea continuar presione salir");
                    respuesta = Console.ReadLine();
                }

                

            }while(numero < 2 || respuesta != "salir");
        }
    }
}
