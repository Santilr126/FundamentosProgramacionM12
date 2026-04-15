using System;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Escribir un algoritmo que permita llenar un vector[15] con números enteros ,y luego encuentre y muestre el valor máximo y minimo de los números ingresados.

            /*int[] numeros = new int[15];
            int numMax = 0;
            int numMin = 0;

            Console.WriteLine("Por favor ingrese 15 numeros enteros");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el valor para asignar en {i}");
                numeros[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    numMax = numeros[0];
                    numMin = numeros[0];
                }
                else
                {
                    if (numeros[i] > numMax)
                    {
                        numMax = numeros[i];
                    }

                    if (numeros[i] < numMin)
                    {
                        numMin = numeros[i];
                    }
                }
            }

            Console.Clear();

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"El valor asignado en {i} es: {numeros[i]}");
            }

            Console.WriteLine($"El valor maximo es: {numMax} y el valor minimo es: {numMin}");*/

            /* 2. Escribir un algoritmo que permita:
                a. Crear dos vestores del mismo tamaño.
                b. Llenarlos con numeros.
                c. Comparar posicion con posicion.
                d. Indicar cuantos elementos son iguales. */

            int[] numeros1 = new int[6];
            int[] numeros2 = new int[6];

            Random random = new Random();
            // Genera un número entre 1 y 10 (10 no incluido)
            int numero = random.Next(1, 11);

            for (int i = 0; i < numeros1.Length; i++)
            {
                numeros1[i] = numero;

                numeros2[i] = numero;
            }

            for (int i = 0; i < numeros1.Length; i++)
            {
                if (numeros1[1] == numeros2[1])
                {

                }
            }
        }
    }
}
