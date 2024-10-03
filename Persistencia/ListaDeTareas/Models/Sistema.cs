namespace ListaDeTareas.Models
{
    public static class Sistema
    {
        static Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>();
        static readonly string archivo = "usuarios.txt";
        static readonly string usuarioSeparador = "-";

        public static void AgregarUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if(!usuarios.ContainsKey(nombreUsuario))
            {
                usuarios[nombreUsuario] = new Usuario(nombreUsuario);
                Console.WriteLine("Usuario agregado de forma correcta...");
            }
            else
            {
                Console.WriteLine("Usuario ya existente");
            }
        }
        public static void AgregarUsuario(Usuario usuario)
        {
            if (!usuarios.ContainsKey(usuario.NombreUsuario))
            {
                usuarios.Add(usuario.NombreUsuario, usuario);
                Console.WriteLine("Usuario agregado de forma correcta...");
            }
            else
            {
                Console.WriteLine("Usuario ya existente");
            }
        }
        public static void AgregarTareaAlUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                Console.WriteLine("Ingrese la descripcion de la tarea: ");
                string descripcion = Console.ReadLine();

                Tarea tarea = new Tarea(descripcion);
                usuarios[nombreUsuario].AgregarTarea(tarea);

                Console.WriteLine($"Tarea agregada al usuario {nombreUsuario}.");
            }
            else
            {
                Console.WriteLine("Usuario inexistente.");
            }
        }
        public static void CambiarEstadoTareaDeUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                Console.Write("Ingrese el número de la tarea a cambiar (empezando desde 0): ");
                int indice = int.Parse(Console.ReadLine());

                usuarios[nombreUsuario].CambiarEstadoTarea(indice);
                Console.WriteLine("Estado de la tarea cambiado.");
            }
            else
            {
                Console.WriteLine("Usuario inexistente.");
            }
        }
        public static void MostrarTareasDeUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                usuarios[nombreUsuario].MostrarTareas();
            }
            else
            {
                Console.WriteLine("Usuario inexistente.");
            }
        }
        public static void GuardarDatos()
        {
            using StreamWriter writer = new StreamWriter(archivo);

            foreach (var usuario in usuarios)
            {
                writer.WriteLine(usuario.Key);

                foreach(var tarea in usuario.Value.Tareas)
                {
                    writer.WriteLine($"{tarea.Descripcion}|{tarea.IsCompletado}");
                }
                writer.WriteLine(usuarioSeparador);
            }
            Console.WriteLine("Datos guardados correctamente.");
        }
    }
}
