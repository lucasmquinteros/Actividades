using PruebaTecnica.Models;

class Program
{
    static void Main()
    {
        Mision m1 = new Mision("Matar zombies", "Medio", 50, 10);
        Mision m2 = new Mision("Batalla campal", "Dificil", 100, 20);
        Mision m3 = new Mision("Lego", "facil", 20, 0);
        MisionCasiImposible m4 = new MisionCasiImposible("Batalla con construccion", "Dificil", 150, 40);
        Aventura A1 = new Aventura("Fortnite");
        A1.addMision(m1);
        A1.addMision(m2);
        A1.addMision(m3);
        A1.addMision(m4);

        Jugador Player1 = new Jugador("Lucas", A1);
        Player1.addAccion("Moverse");
        Player1.addMisionSuperada("Lego");
        Player1.addMisionSuperada("Batalla con construccion");
    }
}