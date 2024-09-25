using System.Security.Cryptography.X509Certificates;

class Estudiante {
    public string Nombre { get; private set; }
    public List<string> Materias{ get; private set; } = new List<string>();
    public Estudiante(string nombre, List<string> materias)
    {
        Nombre = nombre;
        Materias = materias;
    }public Estudiante(string nombre, string materia)
    {
        Nombre = nombre;
        Materias.Add(materia);
    }
    public void MostrarMaterias()
    {
        Console.WriteLine("Materias: ");
        foreach (var materia in Materias)
        {
            Console.WriteLine(materia);
        }
    }
    public void AgregarMateria(string materia)
    {
        Materias.Add(materia);
    }
}

class GrupoEstudiantil
{
    public List<Estudiante> Grupo { get; private set;} =  new List<Estudiante>();
    public string NombreGrupo { get; private set; }
    public GrupoEstudiantil(string nombreGrupo)
    {
        NombreGrupo = nombreGrupo;
        Grupo = new List<Estudiante>();
    }
    public GrupoEstudiantil(List<Estudiante>estudiantes, string nombreGrupo)
    {
        Grupo.AddRange(estudiantes);
        NombreGrupo = nombreGrupo;
    }
    public void AgregarEstudiante(Estudiante estudiante)
    {
        Grupo.Add(estudiante);
    }
    public void MostrarEstudiantes(string materia)
    {
        Console.WriteLine($"Estudiantes en el grupo {NombreGrupo} que estan inscriptos en {materia}: ");
        foreach(var estudiante in Grupo)
        {
            if (estudiante.Materias.Contains(materia))
            {
                Console.WriteLine($"-- {estudiante.Nombre}");
            }
        }
    }
}




static class Sistema
{
    static Dictionary<string, GrupoEstudiantil> grupos = new Dictionary<string, GrupoEstudiantil>();

    public static void CrearGrupo()
    {
        Console.Write("Ingrese el nombre del grupo: ");
        string nombreGrupo = Console.ReadLine();

        grupos[nombreGrupo] = new GrupoEstudiantil(nombreGrupo);
        Console.WriteLine($"Grupo de estudio '{nombreGrupo}' creado");
    }

    public static void AgregarEstudiantes()
    {
        Console.Write("Ingrese el nombre del grupo que quiere ingresar: ");
        string nombreGrupo = Console.ReadLine();
        if (grupos.ContainsKey(nombreGrupo))
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombreEstudiante = Console.ReadLine();
            Console.Write("Ingrese las materias del estudiante, separadas por comas: ");
            string materias = Console.ReadLine();
            List<string> list = new List<string>(materias.Split(','));
            Estudiante estudiante = new Estudiante(nombreEstudiante, list);
            grupos[nombreGrupo].AgregarEstudiante(estudiante);

            Console.WriteLine($"Estudiante: {nombreEstudiante} agregado al grupo {nombreGrupo}");
        }
        else
        {
            Console.WriteLine("El grupo no existe.");
        }
    }
    public static void MostrarEstudiantesPorMateria()
    {
        Console.Write("Ingrese el nombre del grupo: ");
        string nombreGrupo = Console.ReadLine();

        if (grupos.ContainsKey(nombreGrupo))
        {
            Console.Write("Ingrese la materia para filtrar: ");
            string materia = Console.ReadLine();
            grupos[nombreGrupo].MostrarEstudiantes(materia);
        }
        else
        {
            Console.WriteLine("Grupo no encontrado.");
        }
    }
}
class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("== opciones ==");
            Console.WriteLine("1. Ingrese 1 para crear Grupo");
            Console.WriteLine("2. Ingrese 2 para agregar Estudiante");
            Console.WriteLine("3. Mostrar todos los estudiantes por materia");
            Console.WriteLine("4. Salir");

            Console.Write("Ingrese la Opcion: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch(opcion) {
                case 1:
                    Sistema.CrearGrupo();
                    break;
                case 2:
                    Sistema.AgregarEstudiantes();
                    break;
                case 3:
                    Sistema.MostrarEstudiantesPorMateria();
                    break;
                case 4:
                    Console.WriteLine("Saliendo...");
                    break;
            }
        } while (opcion != 4);
    }
}