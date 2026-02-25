using System;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un algoritmo que lea tres numeros A, B, C y visualilice en pantalla el valor más grande. El usuario debe ingresar tres valores diferentes.*/
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese 3 valores diferentes");
            Console.WriteLine("Ingrese el valor del numero 1");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 2");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 3");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1>num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El numero mayor es: {num1}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {num3}");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El numero mayor es: {num2}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {num3}");
                }
            }
        }
    }
}
