using System;

namespace Trabajo_Final_FP
{
    internal class Program
    {
        static bool salir = false;

        static string[] cursos = new string[10];
        static int[] idCursos = new int[10];
        static string[] alumnos = new string[100];
        static int[] idAlumnos = new int[100];
        static int totalCursos = 0;
        static int totalAlumnos = 0;
        static string[,] alumnosCurso = new string[10, 15];
        static int cantidadAlumnos = 0;
        static float[,] notas = new float[10, 15];

        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            int opcion;

            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("--------------------Menu Principal--------------------");
                Console.WriteLine("     Ingrese 1 para ir a la gestión de cursos");
                Console.WriteLine("     Ingrese 2 para ir a la gestión de alumnos");
                Console.WriteLine("     Ingrese 3 para ir a la gestión de notas");
                Console.WriteLine("     Ingrese 4 para salir del programa");
                Console.WriteLine("------------------------------------------------------");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        GestionDeCursos();
                        break;

                    case 2:
                        GestionDeAlumnos();
                        break;

                    case 3:
                        GestionDeNotas();
                        break;

                    case 4:
                        salir = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor ingrese un numero válido");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void GestionDeCursos()
        {
            int opcion;

            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("-------------------------Gestión De Cursos-------------------------");
                Console.WriteLine("     Ingrese 1 para crear un curso");
                Console.WriteLine("     Ingrese 2 para ver la lista de cursos");
                Console.WriteLine("     Ingrese 3 para editar la información de un curso");
                Console.WriteLine("     Ingrese 4 para asignar un alumno a un curso");
                Console.WriteLine("     Ingrese 5 para ver la lista de los estudiantes de un curso");
                Console.WriteLine("     Ingrese 6 para volver al menu principal");
                Console.WriteLine("-------------------------------------------------------------------");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearCurso();
                        break;

                    case 2:
                        VerListaCursos();
                        break;

                    case 3:
                        EditarCurso();
                        break;

                    case 4:
                        AsignarAlumno();
                        break;

                    case 5:
                        VerEstudiantesCurso();
                        break;

                    case 6:
                        MenuPrincipal();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor ingrese un numero válido");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CrearCurso() 
        {
            string nombreCurso;
            int id;

            Console.Clear();

            if (totalCursos >= 10)
            {
                Console.WriteLine("Limite de cursos alcanzado");
                Console.ReadKey();
                GestionDeCursos();
            }
            
            Console.WriteLine("Ingrese el nombre del curso que desea crear");
            nombreCurso = Console.ReadLine();

            Console.WriteLine("Ingrese el ID que se le asignara al curso");
            id = int.Parse(Console.ReadLine());

            cursos[totalCursos] = nombreCurso;
            idCursos[totalCursos] = id;
            totalCursos++;

            Console.WriteLine($"El curso {nombreCurso} fue creado exitosamente");
            Console.ReadKey();
        }

        static void VerListaCursos() 
        {
            Console.Clear();

            if (totalCursos == 0)
            {
                Console.WriteLine("No hay cursos creados");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("---------------Lista De Cursos---------------");
                
                for (int i = 0; i < totalCursos; i++)
                {
                    Console.WriteLine($"{i+1}. {cursos[i]} ID: {idCursos[i]}");
                }
                Console.ReadKey();
            }
        }

        static void EditarCurso() 
        {
            bool cursoEncontrado = false;
            int id;
            
            Console.Clear();
            Console.WriteLine("Ingrese el ID del curso que desea editar");
            id = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalCursos; i++)
            {
                if (idCursos[i] == id)
                {
                    Console.WriteLine("Ingrese el nuevo nombre para el curso");
                    cursos[i] = Console.ReadLine();

                    Console.WriteLine("El nombre del curso se ha actualizado");
                    Console.ReadKey();
                    cursoEncontrado = true;
                }
            }

            if (cursoEncontrado == false)
            {
                Console.Clear();
                Console.WriteLine("Curso no encontrado");
                Console.ReadKey();
            }
        }

        static void AsignarAlumno() 
        {
            int idCurso;
            int idAlumno;
            bool cursoEncontrado = false;
            bool alumnoEncontrado = false;
            
            Console.Clear();
            Console.WriteLine("Ingrese el ID del curso");
            idCurso = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalCursos; i++)
            {
                if (idCursos[i] == idCurso)
                {
                    Console.WriteLine($"Ingrese el ID del alumno que desea asignar a {cursos[i]}");
                    idAlumno = int.Parse(Console.ReadLine());

                    cursoEncontrado = true;

                    if (cantidadAlumnos >= 15)
                    {
                        Console.WriteLine("Este curso ya tiene 15 alumnos.");
                        Console.ReadKey();
                        GestionDeCursos();
                    }

                    for (int j = 0; j < totalAlumnos; j++)
                    {
                        if (idAlumnos[j] == idAlumno)
                        {
                            Console.WriteLine($"El alumno {alumnos[j]} ha sido asignado al curso {cursos[i]}");
                            Console.ReadKey();

                            alumnoEncontrado = true;

                            alumnosCurso[i, cantidadAlumnos] = alumnos[j];
                            cantidadAlumnos++;
                        }
                    }

                    if (alumnoEncontrado == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Alumno no encontrado");
                        Console.ReadKey();
                    }
                }
            }

            if (cursoEncontrado == false)
            {
                Console.Clear();
                Console.WriteLine("Curso no encontrado");
                Console.ReadKey();
            }
        }

        static void VerEstudiantesCurso() 
        {
            bool cursoEncontrado = false;
            int id;

            Console.Clear();
            Console.WriteLine("Ingrese el ID del curso del cual desea ver la lista de alumnos");
            id = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalCursos; i++)
            {
                if (idCursos[i] == id)
                {
                    Console.Clear();
                    Console.WriteLine($"----------Estudiantes {cursos[i]}----------");
                    
                    for (int j = 0; j < totalAlumnos; j++)
                    {
                        Console.WriteLine($"{j+1}. {alumnosCurso[i, j]}");
                    }
                    Console.ReadKey();

                    cursoEncontrado = true;
                }
            }

            if (cursoEncontrado == false)
            {
                Console.Clear();
                Console.WriteLine("Curso no encontrado");
                Console.ReadKey();
            }
        }

        static void GestionDeAlumnos()
        {
            int opcion;

            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("----------------------Gestion De Alumnos----------------------");
                Console.WriteLine("     Ingrese 1 para crear un alumno");
                Console.WriteLine("     Ingrese 2 para ver la lista de todos los estudiantes");
                Console.WriteLine("     Ingrese 3 para editar la informacion de un alumno");
                Console.WriteLine("     Ingrese 4 para volver al menu principal");
                Console.WriteLine("--------------------------------------------------------------");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearAlumno();
                        break;

                    case 2:
                        ListaEstudiantes();
                        break;

                    case 3:
                        EditarAlumno();
                        break;

                    case 4:
                        MenuPrincipal();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor ingrese un numero válido");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CrearAlumno() 
        {
            string nombreAlumno;
            int id;

            Console.Clear();
            
            if (totalAlumnos >= 100)
            {
                Console.WriteLine("Limite de alumnos alcanzado");
                Console.ReadKey();
                GestionDeAlumnos();
            }

            Console.WriteLine("Ingrese el nombre del alumno");
            nombreAlumno = Console.ReadLine();

            Console.WriteLine("Ingrese el ID que se le asignara al alumno");
            id = int.Parse(Console.ReadLine());

            alumnos[totalAlumnos] = nombreAlumno;
            idAlumnos[totalAlumnos] = id;
            totalAlumnos++;

            Console.WriteLine($"El alumno {nombreAlumno} ha sido creado");
            Console.ReadKey();
        }

        static void ListaEstudiantes() 
        {
            Console.Clear();

            if (totalAlumnos == 0)
            {
                Console.WriteLine("No hay alumnos creados");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("---------------Lista De Alumnos---------------");

                for (int i = 0; i < totalAlumnos; i++)
                {
                    Console.WriteLine($"Nombre: {alumnos[i]} ID: {idAlumnos[i]}");
                }
                Console.ReadKey();
            }
        }

        static void EditarAlumno() 
        {
            bool alumnoEncontrado = false;
            int id;

            Console.Clear();
            Console.WriteLine("Ingrese el ID del alumno que desea editar");
            id = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalAlumnos; i++)
            {
                if (idAlumnos[i] == id)
                {
                    Console.WriteLine("Ingrese el nuevo nombre para el alumno");
                    alumnos[i] = Console.ReadLine();

                    Console.WriteLine("El nombre del alumno se ha actualizado");
                    Console.ReadKey();
                    alumnoEncontrado = true;
                }
            }

            if (alumnoEncontrado == false)
            {
                Console.Clear();
                Console.WriteLine("Alumno no encontrado");
                Console.ReadKey();
            }
        }

        static void GestionDeNotas()
        {
            int opcion;

            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("--------------------Gestión De Notas--------------------");
                Console.WriteLine("     Ingrese 1 para registrar notas en un curso");
                Console.WriteLine("     Ingrese 2 para ver las notas de un curso");
                Console.WriteLine("     Ingrese 3 para volver al menu principal");
                Console.WriteLine("--------------------------------------------------------");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarNotas();
                        break;

                    case 2:
                        VerNotas();
                        break;

                    case 3:
                        MenuPrincipal();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor ingrese un numero válido");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void RegistrarNotas() 
        {
            int idCurso;
            bool cursoEncontrado = false;

            Console.Clear();
            Console.WriteLine("Ingrese el ID del curso para registrar notas");
            idCurso = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalCursos; i++)
            {
                if (idCursos[i] == idCurso)
                {
                    for (int j = 0; j < cantidadAlumnos; j++)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingrese la nota final para el alumno {alumnosCurso[i, j]}");
                        notas[i, j] = Single.Parse(Console.ReadLine());
                    }

                    Console.Clear();
                    Console.WriteLine("Notas guardadas");
                    Console.ReadKey();

                    cursoEncontrado = true;
                }
            }

            if (cursoEncontrado == false)
            {
                Console.Clear();
                Console.WriteLine("Curso no encontrado");
                Console.ReadKey();
            }
        }

        static void VerNotas() 
        {
            int idCurso;
            bool cursoEncontrado = false;

            Console.Clear();
            Console.WriteLine("Ingrese el ID del curso del cual desea cosultar las notas");
            idCurso = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalCursos; i++)
            {
                if (idCursos[i] == idCurso)
                {
                    Console.WriteLine($"----------Notas Finales {cursos[i]}----------");

                    for (int j = 0; j < cantidadAlumnos; j++)
                    {
                        Console.WriteLine($"Nombre: {alumnosCurso[i, j]} Nota final: {notas[i, j]}");
                    }
                    Console.ReadKey();

                    cursoEncontrado = true;
                }
            }

            if (cursoEncontrado == false)
            {
                Console.Clear();
                Console.WriteLine("Curso no encontrado");
                Console.ReadKey();
            }
        }
    }
}
