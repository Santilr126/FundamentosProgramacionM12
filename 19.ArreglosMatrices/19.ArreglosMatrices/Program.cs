using System;

namespace _19.ArreglosMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// Declaración e inicialización de matrices
            int[,] numeros = new int[2, 3]; // Rango = Numeros de filas x Numero de columnas
            numeros[0, 0] = 13;
            numeros[0, 1] = 65;
            numeros[0, 2] = 0;
            numeros[1, 0] = 45;
            numeros[1, 1] = 100;
            numeros[1, 2] = 29;

            
            string[,] nombres = 
            {
                {"Ferney", "Juan"},
                {"Maria", "Esteban"},
                {"Alvaro", "Carlos"}
            };

            // Recorrer matriz para llenarla
            char[,] simbolos = new char[2, 5];

            for (int f = 0; f < 2; f++) // Recorre las filas
            {
                for (int c = 0; c < 5; c++) // Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el valor para matriz [{f}, {c}]");
                    simbolos[f, c] = char.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            // Recorre la matriz para recuperar datos
            for (int f = 0; f < simbolos.GetLength(0); f++) // GetLenght(0) devuelve el # de filas
            {
                for (int c = 0; c < simbolos.GetLength(1); c++) // GetLenght(1) devuelve el # de columnas
                {
                    Console.Write($"{simbolos[f,c]} | ");
                    
                }
                Console.WriteLine();
            }*/

            // Escriba un programa que realice la suma de dos matrices de dimenciones 2x3
            
            /* Requisitos del programa:

                    Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 3 columnas.

                    Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimenciones(2x3).
            
                    Calcular la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.
            
                    Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas).*/

            int[,] numeros1 = new int[2, 3];
            int[,] numeros2 = new int[2, 3];
            int[,] suma = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el valor que desea asignar en [{i}, {j}] para la primera matriz");
                    numeros1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el valor que desea asignar en [{i}, {j}] para la segunda matriz");
                    numeros2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma[i, j] = numeros1[i, j] + numeros2[i, j];

                    Console.WriteLine($"La suma de los elementos de las dos matrices en [{i}, {j}] es: {suma[i, j]}");
                }
            }

            /*Desarrolla un algoritmo que realize las siguentes tareas:
              
                    Capturar los nombres de cuatro empleados ingresados por teclado.

                    Para cada empleado, capturar los sueldos recibidos durante los últimos 3 meses.
            
                    Calcular y mostar el total acumulado de sueldos que ha recibido cada empleado en ese periodo.
            
                    Indentificar y mostrar el nombre del empleado con el mayor sueldo acumulado, junto con el monto total que recibió.*/


        }
    }
}
