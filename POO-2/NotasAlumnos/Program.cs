/*
 En una prestigiosa academia, los profesores buscan una forma moderna de gestionar las calificaciones de sus estudiantes.
Con las clases en pleno desarrollo, han solicitado un sistema que les permita registrar las calificaciones de los alumnos, verlas y actualizarlas en caso de ser necesario.
Se debe desarrollar un sistema que almacene los nombres de los estudiantes junto con sus notas.
Los profesores pueden agregar nuevos estudiantes, consultar las notas y modificar calificaciones cuando se descubren errores.
La misión es construir este sistema para asegurar que los maestros mantengan las calificaciones organizadas y siempre actualizadas.

¿Podrás diseñar este sistema de calificaciones que impulse el rendimiento académico de la academia?
 */

public static class Sistema
{
    private static IDictionary<string, int> _estudiantes = new Dictionary<string, int>();
    public static IDictionary<string, int> Estudiantes => _estudiantes;
    public static void AgregarAlumno(string apellido, int nota)
    {
        _estudiantes.Add(apellido, nota);
    }
    public static void ActualizarNota(string apellido)
    {
        if(Estudiantes.ContainsKey(apellido))
        {
            int nota;
            Console.Write("Ingrese la nota del alumno actualizada: ");
            nota = int.Parse(Console.ReadLine());
            _estudiantes[apellido] = nota;
        }
        else
        {
            Console.WriteLine("Ingreso el apellido incorrecto");
        }
    }
    public static void MostrarAlumnos()
    {
        if(_estudiantes.Count > 0)
        {
        Console.WriteLine("Alumnos: ");
        foreach (var estudiante in _estudiantes)
        {
            Console.WriteLine(estudiante.Key + ": " + estudiante.Value);
        }
        }else { Console.WriteLine("No hay alumnos todavia"); }
    }
}
class Program
{
    static void Main()
    {
        int opcion;
        do
        {

            Console.WriteLine("=== Menu de Opciones ===");
            Console.WriteLine("1. Agregar Alumno");
            Console.WriteLine("2. Actualizar Nota de un Alumno");
            Console.WriteLine("3. Mostrar los estudiantes de la materia");
            Console.WriteLine("4. Salir\n");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el Apellido del alumno: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Ingrese la nota del alumno: ");
                    int nota = int.Parse(Console.ReadLine());
                    Sistema.AgregarAlumno(apellido, nota);
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.Write("Ingrese el Apellido del alumno que quiere actualizar: ");
                    string ap = Console.ReadLine();
                    Sistema.ActualizarNota(ap);
                    Console.WriteLine("\n");
                    break;
                case 3:
                    Sistema.MostrarAlumnos();
                    Console.WriteLine("\n");
                    break;
                case 4:
                    Console.WriteLine("Saliendo");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        } while (opcion != 4);
    }
}