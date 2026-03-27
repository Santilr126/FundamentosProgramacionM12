using System;

namespace TallerCiclosPreparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo le permitira al usuario, introducir tantas calificaciones como desee, en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente.*/

            /*int cantidadCalificaciones = 0;
            float calificaciones = 0;
            float promedio;
            string agregarCalificaciones;

            do
            {
                Console.WriteLine("Ingrese su calificación");
                calificaciones += Single.Parse(Console.ReadLine());
                Console.WriteLine("Desea ingresar otra calificación?");
                agregarCalificaciones = Console.ReadLine();

                cantidadCalificaciones++;

            } while (agregarCalificaciones == "si");

            promedio = calificaciones / cantidadCalificaciones;
            Console.WriteLine($"El promedio de las notas es: {promedio}");*/

            /*2. Se requiere un algoritmo para mostrar por pantalla los divisores de un número ingresado por teclado.
                Tener en cuenta que dados don numeros enteros a y b, se dice que b es divisor de a si se cumple que al efectuar una división entera a/b el residuo es 0, en C# utilizar el operador Mod para obtener el resudio de una divisiónde dos números*/

            /*int num;

            Console.WriteLine("Ingrese cualquier numero entero");
            num=int.Parse(Console.ReadLine());
            Console.WriteLine($"Los divisores de {num} son:");

            for (int contador = 1; contador <= num; contador++) 
            {
                if (num % contador == 0)
                {
                    Console.WriteLine(contador);
                }
            }*/

            /*3. Dados dos numeros enteros ingresados por teclado: b que es la base y e que es el exponente, se requiere calcular el resultado de la potenciación.
                Mostrar en pantalla el resultado de la potenciación.
                Seguir pidiendo por teclado la base y el exponente y realizar la potenciación correspondiente, hasta que el usuario ingrese por teclado el carácter de escape"n"*/

            int baseB;
            int exponente;

            
        }
    }
}
