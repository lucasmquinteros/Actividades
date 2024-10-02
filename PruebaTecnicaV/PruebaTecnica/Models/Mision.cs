
namespace PruebaTecnica.Models
{
    public class Mision
    {
        public string Nombre { get; private set; }
        public string Dificultad {  get; private set; }
        public int PuntosEXdeRecompensa { get; private set; }
        public int MinimoPuntosEXRequeridos { get; private set; }
        public Mision(string nombre, string dificultad, int puntosEXdeRecompensa, int minimoPuntosEXRequeridos)
        {
            Nombre = nombre;
            Dificultad = dificultad;
            PuntosEXdeRecompensa = puntosEXdeRecompensa;
            MinimoPuntosEXRequeridos = minimoPuntosEXRequeridos;
        }
        //obtener nombre de mision
        public string getNombre()
        {
            return Nombre;
        }
        //obtener puntos de recompensa
        public int getPuntosEXRecompensa()
        {
            return PuntosEXdeRecompensa;
        }
        //conocer si el jugador tiene la capacidad de superar la mision
        public bool superaMision(Jugador jugador)
        {
            if(jugador.puntosExperienciaAcomulados < MinimoPuntosEXRequeridos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
