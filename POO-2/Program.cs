public class Tarea {
    public string tarea { get; set; }
    public bool IsRealizada {get; set;} = false;
    public Tarea(string tarea)
    {
        this.tarea = tarea;
    }

}
/**
 * mostrar todas las tareas
 * mostrar tareas completadas
 * editar una tarea
 */



public class Program
{
    static void Main()
    {
        List<Tarea> listaTareas = new List<Tarea>();

        int opcion;

        do
        {
            Console.WriteLine("1. Agregar una nueva tarea");
            Console.WriteLine("2. Completar una tarea");
            Console.WriteLine("3. Mostrar todas las tareas pendientes");
            Console.WriteLine("4. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la nueva tarea: ");
                    Tarea tarea = new Tarea(Console.ReadLine());
                    listaTareas.Add(tarea);
                    break;
                case 2:
                    Console.WriteLine("Cual Tarea quiere marcar como completada?");
                    for(int i = 0; i < listaTareas.Count; i++)
                    {
                        Console.WriteLine($"{i+1}. {listaTareas[i].tarea}");
                    }
                    int opcion2;
                    Console.Write("Ingrese el numero de la tarea: ");
                    opcion2 = int.Parse(Console.ReadLine());
                    if(opcion2 >= 0 && opcion2 < listaTareas.Count)
                    {
                        listaTareas[opcion].IsRealizada = true;
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Tareas pendientes");
                    foreach (var tar in listaTareas)
                    {
                        if(tar.IsRealizada == false)
                        {
                            Console.WriteLine(tar.tarea);
                        }
                    }
                    Console.WriteLine("\n");
                    break;
            }
        } while (opcion != 4);
        Console.WriteLine("Pulse cualquier tecla para salir: ");
        Console.ReadKey();
    }
}