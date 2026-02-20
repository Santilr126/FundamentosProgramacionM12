using System;

namespace _2.CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pnatalla con el nombre de la persona , indicando que debe abonar impuestos.*/
            /*string nombre = "";
            float sueldo = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre=Console.ReadLine();//lo que llega desde la consola, es de tipo string
            Console.WriteLine("ingrese el sueldo del usuario");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo>=3000)
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }*/

            /*2. Crear un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bievenido a mi sitio web*/
            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad>=18)
            {
                Console.WriteLine($"Bienvenido a mi sitio web");
            }
        }
    }
}
