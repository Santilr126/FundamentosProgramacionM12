using System;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TipoDePizza;
            string Ingrediente1;
            string Ingrediente2;
            string Ingrediente3;
            string TotalIngredientes;
            float PrecioBase;
            float PrecioFinal;

            Console.WriteLine("Por favor escribir la primera letra en mayúscula");
            Console.WriteLine("Seleccione el tipo de pizza: Vegetariana, No vegetariana");
            TipoDePizza = Console.ReadLine();

            if (TipoDePizza=="Vegetariana")
            {
                Console.WriteLine("Selecione 3 de los siguientes ingredientes: Pimiento, Tofu, Champiñones, Tomate, Lechuga");
                Console.WriteLine("Ingrese el primer ingrediente");
                Ingrediente1 = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo ingrediente");
                Ingrediente2 = Console.ReadLine();
                Console.WriteLine("Ingrese el tercer ingrediente");
                Ingrediente3 = Console.ReadLine();
                TotalIngredientes = Ingrediente1 + Ingrediente2 + Ingrediente3;

                switch (TotalIngredientes)
                {
                    case "PimientoChampiñonesLechuga":
                        PrecioBase = 20000f;
                        PrecioFinal = PrecioBase + (PrecioBase * 0.19f);
                        Console.WriteLine("Resumen de la compra:");
                        Console.WriteLine($"Tipo de pizza: {TipoDePizza}");
                        Console.WriteLine($"Ingredientes seleccionados: {Ingrediente1}, {Ingrediente2}, {Ingrediente3}");
                        Console.WriteLine("Valor IVA: 19%");
                        Console.WriteLine($"Valor a pagar: ${PrecioFinal}");
                        break;

                    case "TofuChampiñonesLechuga":
                        PrecioBase = 30000f;
                        PrecioFinal = PrecioBase + (PrecioBase * 0.15f);
                        Console.WriteLine("Resumen de la compra:");
                        Console.WriteLine($"Tipo de pizza: {TipoDePizza}");
                        Console.WriteLine($"Ingredientes seleccionados: {Ingrediente1}, {Ingrediente2}, {Ingrediente3}");
                        Console.WriteLine("Valor IVA: 15%");
                        Console.WriteLine($"Valor a pagar: ${PrecioFinal}");
                        break;


                    default:
                        PrecioBase = 25000f;
                        PrecioFinal = PrecioBase + (PrecioBase * 0.1f);
                        Console.WriteLine("Resumen de la compra:");
                        Console.WriteLine($"Tipo de pizza: {TipoDePizza}");
                        Console.WriteLine($"Ingredientes seleccionados: {Ingrediente1}, {Ingrediente2}, {Ingrediente3}");
                        Console.WriteLine("Valor IVA: 10%");
                        Console.WriteLine($"Valor a pagar: ${PrecioFinal}");
                        break;
                }
            }
            else if (TipoDePizza=="No vegetariana")
            {
                Console.WriteLine("Selecciones 2 de los siguientes ingredientes: Res, Chorizo, Pollo, Tocineta, Cerdo");
                Console.WriteLine("Ingrese el primer ingrediente");
                Ingrediente1 = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo ingrediente");
                Ingrediente2 = Console.ReadLine();
                TotalIngredientes = Ingrediente1 + Ingrediente2;

                switch (TotalIngredientes)
                {
                    case "ResPollo":
                        PrecioBase = 10000f;
                        PrecioFinal = PrecioBase + (PrecioBase * 0.19f);
                        Console.WriteLine("Resumen de la compra:");
                        Console.WriteLine($"Tipo de pizza: {TipoDePizza}");
                        Console.WriteLine($"Ingredientes seleccionados: {Ingrediente1}, {Ingrediente2}");
                        Console.WriteLine("Valor IVA: 19%");
                        Console.WriteLine($"Valor a pagar: ${PrecioFinal}");
                        break;

                    case "ResTocineta":
                        PrecioBase = 15000f;
                        PrecioFinal = PrecioBase + (PrecioBase * 0.17f);
                        Console.WriteLine("Resumen de la compra:");
                        Console.WriteLine($"Tipo de pizza: {TipoDePizza}");
                        Console.WriteLine($"Ingredientes seleccionados: {Ingrediente1}, {Ingrediente2}");
                        Console.WriteLine("Valor IVA: 17%");
                        Console.WriteLine($"Valor a pagar: ${PrecioFinal}");
                        break;

                    case "ChorizoTocineta":
                        PrecioBase = 25000f;
                        PrecioFinal = PrecioBase + (PrecioBase * 0.9f);
                        Console.WriteLine("Resumen de la compra:");
                        Console.WriteLine($"Tipo de pizza: {TipoDePizza}");
                        Console.WriteLine($"Ingredientes seleccionados: {Ingrediente1}, {Ingrediente2}");
                        Console.WriteLine("Valor IVA: 9%");
                        Console.WriteLine($"Valor a pagar: ${PrecioFinal}");
                        break;

                    default:
                        PrecioBase = 22000f;
                        PrecioFinal = PrecioBase + (PrecioBase * 0.1f);
                        Console.WriteLine("Resumen de la compra:");
                        Console.WriteLine($"Tipo de pizza: {TipoDePizza}");
                        Console.WriteLine($"Ingredientes seleccionados: {Ingrediente1}, {Ingrediente2}");
                        Console.WriteLine("Valor IVA: 10%");
                        Console.WriteLine($"Valor a pagar: ${PrecioFinal}");
                        break;
                }
            }
        }
    }
}
