using System;

namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7.Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber: 
            Si el día es martes o jueves, se realizará un descuento del 15 % por la compra.  
            Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra. 
            Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra. 
            Si es domingo no se realiza descuento.
            Visualizar el día, el descuento y el total a pagar por la compra.*/

            /*string diaSemana = "";
            float subtotal = 0;
            float descuento = 0;

            Console.WriteLine("Ingrese monto de la compra");
            subtotal = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana");
            diaSemana = Console.ReadLine();

            switch (diaSemana)
            {
                case "lunes":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy es lunes, el descuento es de {descuento}, el valor total a pagar es de {subtotal-descuento}");
                    break;

                case "martes":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es martes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "miercoles":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy es miercoles, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "jueves":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es jueves, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "viernes":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"Hoy es viernes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "sabado":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"Hoy es sabado, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "domingo":
                    descuento = subtotal * 0f;
                    Console.WriteLine($"Hoy es domingo, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                default:
                    Console.WriteLine("Por favor ingrese un dia de la semana correcto");
                    break;
            }*/

            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos numeros ingresados por el usuario. Las operaciones disponibles serán; suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario*/

            float num1 = 0;
            float num2 = 0;
            float resultado = 0;
            string operacion;

            Console.WriteLine("Ingrese el primer numero");
            num1=Single.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la operacion que desea hacer");
            operacion = Console.ReadLine();

            switch (operacion)
            {
                case "suma":
                    resultado = num1 + num2;
                    Console.WriteLine($"La suma entre {num1} y {num2} es: {resultado}");
                    break;

                case "resta":
                    resultado = num1 - num2;
                    Console.WriteLine($"La resta entre {num1} y {num2} es: {resultado}");
                    break;

                case "multiplicacion":
                    resultado = num1 * num2;
                    Console.WriteLine($"La multiplicación entre {num1} y {num2} es: {resultado}");
                    break;

                case "division":
                    resultado = num1 / num2;
                    Console.WriteLine($"La divición entre {num1} y {num2} es: {resultado}");
                    break;

                default:
                    Console.WriteLine("Por favor ingrese una operación correcta");
                    break;
            }
        }
    }
}
