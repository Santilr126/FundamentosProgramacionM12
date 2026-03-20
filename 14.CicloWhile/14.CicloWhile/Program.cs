using System;

namespace _14.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algortimo que permita calcular y mostrar por pantalla los primeros números primos hasta el número 100.*/

            /*int contadorNumeros = 1;
            int contador = 1;
            int contadorDivisores = 0;

            do
            {
                do
                {
                    if (contadorNumeros%contador==0)
                    {
                        contadorDivisores++;
                    }
                    contador++;

                } while (contador <= contadorNumeros);

                contador = 1;

                if (contadorDivisores==2)
                {
                    Console.WriteLine(contadorNumeros);
                }

                contadorDivisores = 0;
                contadorNumeros++;

            } while (contadorNumeros <= 100);*/

            /*Escribe un algoritmo que actúe como una calculadora básica. El algortimo le debe permitir al usuario elegir una operación (suma, resta, multiplicación, división), y luego ingresar dos números. El ciclo debe continuar permitiendo al usuario realizar más cálculos hasta que elija salir.*/

            string operacion;
            float num1;
            float num2;
            float resultado;
            string reiniciar;

            do 
            {
                Console.Clear();
                Console.WriteLine("Ingrese el primer numero:");
                num1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:");
                num2 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Selecione la operación que desea realizar: Suma = S, Resta = R, Multiplicación = M, División = D");
                operacion = Console.ReadLine();

                switch (operacion)
                {
                    case "S":
                        resultado = num1 + num2;
                        Console.WriteLine($"La suma entre {num1} y {num2} es: {resultado}");
                        break;

                    case "R":
                        resultado = num1 - num2;
                        Console.WriteLine($"La resta entre {num1} y {num2} es: {resultado}");
                        break;

                    case "M":
                        resultado = num1 * num2;
                        Console.WriteLine($"La multiplicación entre {num1} y {num2} es: {resultado}");
                        break;

                    case "D":
                        resultado = num1 / num2;
                        Console.WriteLine($"La división entre {num1} y {num2} es: {resultado}");
                        break;

                    default:
                        Console.WriteLine("Por favor ingrese un dato valido");
                        break;
                }

                Console.WriteLine("Desea hacer otra operación? Si, No");
                reiniciar = Console.ReadLine();

            } while (reiniciar=="Si");
        }
    }
}
