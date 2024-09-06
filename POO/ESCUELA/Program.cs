/*
 La "Escuela Angelitos" es una institución educativa donde cada aula tiene su propio grupo de estudiantes y está bajo la guía de un profesor dedicado.
Los estudiantes se inscriben en diferentes aulas según su nivel y cada aula está diseñada para proporcionar un ambiente de aprendizaje óptimo.
María López, la profesora de Matemáticas, y Carlos García, el profesor de Ciencias, son dos de los profesores que trabajan en esta escuela.
María enseña en el Aula 1, donde Ana de 10 años y Luis de 11 años son sus estudiantes. Carlos enseña en el Aula 2, donde su única estudiante
es Elena de 10 años de edad.

El director de la escuela, Juan Pérez, ha estado trabajando en la institución durante los últimos 15 años y tiene una vasta experiencia en la
administración escolar. Él se encarga de supervisar todas las operaciones de la escuela y asegurar que todo funcione sin problemas.

Recientemente, Juan ha decidido implementar un sistema de gestión para la escuela que le permita tener una visión clara de cada aula, los profesores
asignados y los estudiantes inscritos en cada una de ellas. Este sistema debe ser capaz de mostrar detalles sobre la escuela, incluyendo la
información del administrador, los profesores, y los estudiantes de cada aula.

Tu tarea:

Ayuda a Juan a implementar este sistema de gestión escolar. Necesitas desarrollar un programa que represente la estructura de la escuela, las aulas,
los estudiantes y los profesores. El sistema debe permitir a Juan ingresar y visualizar la información detallada de la escuela, incluidas las aulas con
sus respectivos profesores y estudiantes, así como la información del administrador.
 */
using ESCUELA.Modelos;
class Program
{
    static void Main()
    {
        Administrador administrador = new Administrador("Juan Pérez", 15);

        Console.WriteLine("Ingrese el Nombre de la escuela");
        string Nombre = Console.ReadLine();

        Escuela escuela = new Escuela(Nombre, administrador);

        Console.WriteLine("Ingrese la cantidad de aulas que tiene la escuela");
        int cantidadAulas;
        int.TryParse(Console.ReadLine(), out cantidadAulas);
        for (int i = 0; i < cantidadAulas; i++)
        {

            Console.WriteLine("Ingrese el Nombre del Aula");
            string nombreAula = Console.ReadLine();

            Console.WriteLine("Ingrese el Nombre del Profesor del Aula");
            string nombreProfesor = Console.ReadLine();

            Profesor profesor = new Profesor(nombreProfesor);


            Console.WriteLine("Ingrese el Nombre de la Materia que enseña el profesor");
            string nombreMateria = Console.ReadLine();

            Console.WriteLine("Ingrese los creditos de la materia");
            int Creditos;
            int.TryParse(Console.ReadLine(), out Creditos);

            
            Materia materia = new Materia(nombreMateria, Creditos);
            
            profesor.Añadir(materia);

            Aula aula = new Aula(nombreAula, profesor);


            Console.WriteLine("Ingrese la cantidad de alumnos del aula");
            int cantidadAlumnos;
            int.TryParse(Console.ReadLine(), out cantidadAlumnos);

            

            for (int j = 0; j < cantidadAlumnos; j++)
            {
                Console.WriteLine("Ingrese el Nombre del Alumno: ", j + 1);
                string nombreAlumno = Console.ReadLine();

                Console.WriteLine("Ingrese la Edad del Alumno: ", j + 1);
                int edadAlumno;
                int.TryParse(Console.ReadLine(), out edadAlumno);

                Estudiante alumno = new Estudiante(edadAlumno, nombreAlumno);
                aula.Añadir(alumno);

            }

            escuela.Añadir(aula);

            
        }
        
        escuela.MostrarDetalles();

        Console.WriteLine("----------------------------------------------------------------------------");

        Proyecto proyecto1 = new Proyecto("Proyecto de ciencias", "Investigacion sobre fisica Cuantica");
        Evaluador evaluador1 = new Evaluador("Sofia lala", "Fisica");

        proyecto1.EvaluarProyecto(evaluador1);
    }
}