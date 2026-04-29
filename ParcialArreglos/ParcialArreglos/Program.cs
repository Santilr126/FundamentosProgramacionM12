using System;

namespace ParcialArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] datosEstudiantes = new string[6, 6];
            int grado;
            decimal notaParcial1;
            decimal notaParcial2;
            decimal examenFinal;
            decimal notaFinal;

            datosEstudiantes[0, 0] = "Nombre del Estudiante";
            datosEstudiantes[0, 1] = "Grado";
            datosEstudiantes[0, 2] = "Nota Parcial 1";
            datosEstudiantes[0, 3] = "Nota Parcial 2";
            datosEstudiantes[0, 4] = "Examen Final";
            datosEstudiantes[0, 5] = "Nota Final";
            
            for (int i = 1; i < 6; i++)
            {
                Console.Clear();
                Console.WriteLine($"Ingrese el nombre del estudiante numero {i}");
                datosEstudiantes[i, 0] = Console.ReadLine();

                Console.WriteLine("Ingrese a que grado pertenece");
                grado = int.Parse(Console.ReadLine());
                datosEstudiantes[i, 1] = Convert.ToString(grado);

                Console.WriteLine("Ingrese la nota de su primer parcial");
                notaParcial1 = decimal.Parse(Console.ReadLine());
                datosEstudiantes[i, 2] = Convert.ToString(notaParcial1);

                Console.WriteLine("Ingrese la nota de su segundo parcial");
                notaParcial2 = decimal.Parse(Console.ReadLine());
                datosEstudiantes[i, 3] = Convert.ToString(notaParcial2);

                Console.WriteLine("Ingrese la nota de su examen final");
                examenFinal = decimal.Parse(Console.ReadLine());
                datosEstudiantes[i, 4] = Convert.ToString(examenFinal);

                notaFinal = (notaParcial1 + notaParcial2 + examenFinal) / 3;
                datosEstudiantes[i, 5] = Convert.ToString(notaFinal);
            }

            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {datosEstudiantes[0, 0]} | {datosEstudiantes[0, 1]} | {datosEstudiantes[0, 2]} | {datosEstudiantes[0, 3]} | {datosEstudiantes[0, 4]} | {datosEstudiantes[0, 5]} |");
            Console.WriteLine($"|    {datosEstudiantes[1, 0]}    |    {datosEstudiantes[1, 1]}      |      {datosEstudiantes[1, 2]}      |      {datosEstudiantes[1, 3]}      |      {datosEstudiantes[1, 4]}      |      {datosEstudiantes[1, 5]}");
            Console.WriteLine($"|    {datosEstudiantes[2, 0]}    |    {datosEstudiantes[2, 1]}      |      {datosEstudiantes[2, 2]}      |      {datosEstudiantes[2, 3]}      |      {datosEstudiantes[2, 4]}      |      {datosEstudiantes[2, 5]}");
            Console.WriteLine($"|    {datosEstudiantes[3, 0]}    |    {datosEstudiantes[3, 1]}      |      {datosEstudiantes[3, 2]}      |      {datosEstudiantes[3, 3]}      |      {datosEstudiantes[3, 4]}      |      {datosEstudiantes[3, 5]}");
            Console.WriteLine($"|    {datosEstudiantes[4, 0]}    |    {datosEstudiantes[4, 1]}      |      {datosEstudiantes[4, 2]}      |      {datosEstudiantes[4, 3]}      |      {datosEstudiantes[4, 4]}      |      {datosEstudiantes[4, 5]}");
            Console.WriteLine($"|    {datosEstudiantes[5, 0]}    |    {datosEstudiantes[5, 1]}      |      {datosEstudiantes[5, 2]}      |      {datosEstudiantes[5, 3]}      |      {datosEstudiantes[5, 4]}      |      {datosEstudiantes[5, 5]}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }
    }
}
