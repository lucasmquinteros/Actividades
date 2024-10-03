<<<<<<< HEAD
﻿namespace ListaDeTareas.Models
{
    public class Usuario
    {
        public string NombreUsuario { get; private set; }
        public List<Tarea> Tareas { get; private set; } = new List<Tarea>();
        public Usuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }
        public void AgregarTarea(Tarea tarea) => Tareas.Add(tarea);          
        
        public void MostrarTareas()
        {
            if (Tareas.Count > 0)
            {
                Console.WriteLine($"\nTareas de {NombreUsuario}: ");
                foreach (Tarea tarea in Tareas)
                {
                    Console.WriteLine(tarea);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No hay tareas aún.");
            }
        }
        public void CambiarEstadoTarea(int indice)
        {
            if(indice >= 0 &&  indice < Tareas.Count)
            {
                Tareas[indice].IsCompletado = !Tareas[indice].IsCompletado;
            }
            else
            {
                Console.WriteLine(new IndexOutOfRangeException().ToString());
            }
        }

    }
}
=======
﻿namespace ListaDeTareas.Models
{
    public class Usuario
    {
        public string NombreUsuario { get; private set; }
        public List<Tarea> Tareas { get; private set; } = new List<Tarea>();
        public Usuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }
        public void AgregarTarea(Tarea tarea) => Tareas.Add(tarea);          
        
        public void MostrarTareas()
        {
            if (Tareas.Count > 0)
            {
                Console.WriteLine($"\nTareas de {NombreUsuario}: ");
                foreach (Tarea tarea in Tareas)
                {
                    Console.WriteLine(tarea);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No hay tareas aún.");
            }
        }
        public void CambiarEstadoTarea(int indice)
        {
            if(indice >= 0 &&  indice < Tareas.Count)
            {
                Tareas[indice].IsCompletado = !Tareas[indice].IsCompletado;
            }
            else
            {
                Console.WriteLine(new IndexOutOfRangeException().ToString());
            }
        }

    }
}
>>>>>>> b945f3d38d98caebba8bafa089e8be49b0129c4a
