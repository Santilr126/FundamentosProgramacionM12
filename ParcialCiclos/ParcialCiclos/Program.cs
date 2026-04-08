using System;

namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numProductos = 0;
            float valorProducto;
            float subtotal;
            float valorTotal = 0;

            Console.WriteLine("Por favor ingrese el valor de 10 productos");

            do
            {
                Console.WriteLine("Ingrese el valor de su producto");
                valorProducto = Single.Parse(Console.ReadLine());

                if (valorProducto > 10000)
                {
                    subtotal = valorProducto + (valorProducto * 0.15f);
                    valorTotal += subtotal;
                }
                else if (valorProducto <= 5000)
                {
                    subtotal = valorProducto + (valorProducto * 0.19f);
                    valorTotal += subtotal;
                }
                else
                {
                    subtotal = valorProducto;
                    valorTotal += subtotal;
                }

                numProductos++;
                
            } while (numProductos <= 10);

            Console.Clear();
            Console.WriteLine($"El valor total de la venta es: {valorTotal}");
        }
    }
}
