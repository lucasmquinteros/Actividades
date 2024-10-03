namespace RegistroContactos.modulos
{
    public class Sistema
    {
        static List<Contacto> contactos = new List<Contacto>();
        static readonly string archivo = "archivo.txt";
        static readonly string sc = "-";
        public static void AgregarContacto()
        {
            Console.Write("Ingrese el nombre del contacto: ");
            string nombreContacto = Console.ReadLine();
            Console.Write("Ingrese el telefono del contacto: ");
            int telefonoContacto = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el correo del contacto: ");
            string correoContacto = Console.ReadLine();
            bool IsExistente = false;
            foreach(Contacto c in contactos)
            {
                if(c.Nombre == nombreContacto && c.Telefono == telefonoContacto)
                {
                    IsExistente = true;
                }
            }if(!IsExistente)
            {
            Contacto contacto = new Contacto(nombreContacto, telefonoContacto, correoContacto);
            contactos.Add(contacto);
            Sistema.GuardarContacto(contacto);
            }
        }
        public static void MostrarContactos()
        {
            Console.WriteLine("Contactos: ");
            foreach (Contacto contacto in contactos)
            {
                Console.WriteLine($"{contacto.Nombre}{sc}{contacto.Telefono}{sc}{contacto.CorreoElectronico}");
            }
        }
        public static void GuardarDatos()
        {
            using StreamWriter writer = new StreamWriter(archivo);

            foreach(Contacto contacto in contactos)
            {
                writer.WriteLine($"{contacto.Nombre}{sc}{contacto.Telefono}{sc}{contacto.CorreoElectronico}");
            }
        }
        public static void CargarDatos()
        {
            if (File.Exists(archivo))
            {
                using StreamReader reader = new StreamReader(archivo);
                string linea = null;

                while ((linea = reader.ReadLine()) != null)
                {
                    string[] partes = linea.Split(sc);

                    string nombre = partes[0];
                    int telefono = int.Parse(partes[1]);
                    string correoContacto = partes[2];
                
                    contactos.Add(new Contacto(nombre, telefono, correoContacto));
                }
            }
        }
        public static void GuardarContacto(Contacto contacto)
        {
            using StreamWriter writer = new StreamWriter(archivo, true); //utilizo la sobrecarga de append, que no sobreescribe desde el principio
            writer.WriteLine($"{contacto.Nombre}{sc}{contacto.Telefono}{sc}{contacto.CorreoElectronico}");
        }
    }
}
