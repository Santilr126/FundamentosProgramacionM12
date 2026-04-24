using System;

namespace _20.ProgramacionModular
{
    internal class Program
    {
        static int añoActual = 2026;
        
        static void Main(string[] args)
        {
            // Programación Modular
            string nombre = "Santiago";
            string apellidos = "López Rodriguez";
            Console.WriteLine($"Edad: {EdadAñoNacimiento()}");
            Saludo(nombre, apellidos);
            Console.WriteLine($"Edad: {EdadAñoNacimiento(2001)}");
            Console.ReadKey();
            BorrarPantalla();
        }

        // Procedimiento sin parámetros
        static void BorrarPantalla() 
        {
            Console.Clear();
        }

        // Procedimientos con parámetros
        static void Saludo(string nombre, string apellidos) 
        {
            Console.WriteLine($"Bienvenido {nombre} {apellidos}, a la programación modular");
        }

        // Funciones sin parámetros
        static int EdadAñoNacimiento() 
        {
            int añoNacimiento = 2006;
            int edad = añoActual - añoNacimiento;
            return edad;
        }

        // Funciones con parámetros
        static int EdadAñoNacimiento(int añoNacimiento) 
        {
            return añoActual - añoNacimiento;
        }
    }
}
