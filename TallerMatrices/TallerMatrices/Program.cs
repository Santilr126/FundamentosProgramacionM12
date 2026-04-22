using System;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla la suma de los elementos de cada columna.

            /*int[,] numeros = new int[10, 20];
            int[] sumaColumnas=new int[20];
            Random random = new Random();
            numeros[0, 0] = random.Next(0, 11);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++) 
                {
                    numeros[i, j] = random.Next(0,10);                    
                }
            }

            for (int i = 0; i < numeros.GetLength(1); i++)
            {
                for (int j = 0; j < numeros.GetLength(0); j++)
                {
                    sumaColumnas[i] += numeros[j, i];
                }
                Console.WriteLine($"Suma de la columna {i+1} es: {sumaColumnas[i]}");
            }*/

            //2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa caracteres en cada posición de la matriz hasta llenarla.El programa debe intercambiar la primera fila con la última fila de la matriz.Al final se debe imprimir la matriz original, y la matriz con el intercambio de filas.

            char[,] caracteres = new char[3, 2];
            
            caracteres[0, 0] = 's';
            caracteres[0, 1] = '?';
            caracteres[1, 0] = 'l';
            caracteres[1, 1] = '%';
            caracteres[2, 0] = 'r';
            caracteres[2, 1] = '&';


        }
    }
}
