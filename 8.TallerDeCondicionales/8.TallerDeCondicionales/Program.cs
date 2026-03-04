using System;

namespace _8.TallerDeCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.*/
            
            float num1;
            float num2;
            float num3;

            Console.WriteLine("Ingrese el primer numero");
            num1=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = Single.Parse(Console.ReadLine());

            if (num1 == num2 || num2 == num3 || num1 == num3)
            {
                Console.WriteLine("Se deben ingresar numeros diferentes");
                return;
            }
            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El numero mayor es: {num1}, el segundo mayor es: {num2} y el menor es {num3}");
                }
                else if (num2 < num3 && num1 > num3)
                {
                    Console.WriteLine($"El numero mayor es: {num1}, el segundo mayor es: {num3} y el menor es {num2}");
                }
            }
            else if (num2 > num1)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El numero mayor es: {num2}, el segundo mayor es: {num1} y el menor es {num3}");
                }
                else if (num1 < num3 && num2 > num3)
                {
                    Console.WriteLine($"El numero mayor es: {num2}, el segundo mayor es: {num3} y el menor es {num1}");
                }
            }
            if (num3 > num1)
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"El numero mayor es: {num3}, el segundo mayor es: {num1} y el menor es {num2}");
                }
                else if (num1 < num2 && num3 > num2)
                {
                    Console.WriteLine($"El numero mayor es: {num3}, el segundo mayor es: {num2} y el menor es {num1}");
                }
            }
        }
    }
}
