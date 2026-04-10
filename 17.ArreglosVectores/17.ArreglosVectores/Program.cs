using System;

namespace _17.ArreglosVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros = new int[5]; // El rango de este vector es 5
            numeros[0] = 12;
            numeros[1] = 13;
            numeros[2] = 42;
            numeros[3] = 201;
            numeros[4] = 0;
            // numeros[5] = 1; La posicion 6 con indice 5 no existe, porque el rango del vector es 5
            Console.WriteLine($"El valor almacenado en la posicion 3, con inidice 2 es: {numeros[2]}");

            // Recorrer el vector para llenarlo

            string[] nombres = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre para guardar en la posicion {i + 1} con indice {i}");
                nombres[i] = Console.ReadLine();
            }

            char[] simbolos = new char[] { '#', '%', '?', '|', 'Q', 'ñ', '&', '9', '*' };

            // Recorrer vector para recuperar los datos almacenados en el
            
            for (int i = 0; i < simbolos.Length; i++)
            {
                Console.Write(simbolos[i] + " | ");
            }*/

            // Crear arreglo llamado "numeros" de 100 elementos, asignar el numero 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y escribirlo en pantalla.

            /*int[] numeros = new int[100];

            for (int i = 0; i < numeros.Length; i++) 
            { 
                numeros[i] = 10;
                Console.WriteLine($"El elemento asignado en la posicion {i} es: {numeros[i]}");
            }*/

            // Llene un arreglo con 15 números ingresados por teclado. Una vez registrado el total de valores, muestre en pantalla todos los elementos del arreglo. Finalmente, determine cuál es el número mayor y cuál es el número menor, junto con la posición que ocupa cada uno dentro del arreglo.

            int[] numeros = new int[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero para asignar en la posicion {i}");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"El valor asignado en {i} es: {numeros[i]}");
            }
        }
    }
}
