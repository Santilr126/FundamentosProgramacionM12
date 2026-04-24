using System;

namespace _21.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostarMenu();
            int opcion = CapturarOpcion();
            RealizarOperacion(opcion);
        }

        static void MostarMenu() 
        {
            Console.WriteLine("---------------------MENÚ---------------------");
            Console.WriteLine("     1. Suma                  2. Resta");
            Console.WriteLine("     3. Multiplicación        4. División");
            Console.WriteLine("----------------------------------------------");
        }

        static int CapturarOpcion() 
        {
            Console.WriteLine("Ingrese una opción del menu");
            return int.Parse(Console.ReadLine());
        }

        static void RealizarOperacion(int opcion) 
        {
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;

                case 2:
                    Resta();
                    break;

                case 3:
                    Multiplicacion();
                    break;

                case 4:
                    Division();
                    break;

                default:
                    Console.WriteLine("Ingrese una opción válida del menú");
                    break;
            }
        }

        static void Division()
        {
            Console.WriteLine("Usted va a dividir");
        }

        static void Multiplicacion()
        {
            Console.WriteLine("Usted va a multiplicar");
        }

        static void Resta()
        {
            Console.WriteLine("Usted va a restar");
        }

        static void Suma() 
        {
            Console.WriteLine("Usted va a sumar");
        }
    }
}
