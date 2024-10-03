using Parcial.Modulos;

class Program
{
    static void Main()
    {
        Miembro miembro1 = new Miembro("Lucas");
        Miembro miembro2 = new Miembro("Agustin");
        miembro1.MostrarDetalles();
        miembro2.MostrarDetalles();
        Console.WriteLine();
        Instructor Juan = new Instructor("Juan Perez", "Profesor de Educacion Fisica");
        Clase Hit = new Clase("Clase de HIT", Juan, 20);
        Hit.AgregarMiembro(miembro1);
        Instructor Diego = new Instructor("Diego", "10 Años de Experiencia");
        Clase Escalada = new Clase("Clase de Escalada", Diego, 900);
        Gimnasio gimnasio = new Gimnasio("Cefide");
        gimnasio.AgregarClase(Hit);
        gimnasio.AgregarClase(Escalada);
        gimnasio.MostrarDetalles();
    }
}