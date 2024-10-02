namespace PruebaTecnica.Models
{
    public class Aventura
    {
        public string Nombre { get; private set; }
        public Dictionary<string, Mision> Misiones { get; private set; } = new();
        public List<Jugador> Jugadores { get; private set; } = new List<Jugador>();
        public Aventura(string nombre)
        {
        Nombre = nombre; 
        }
        public bool addMision(Mision mision)
        {
            if (Misiones.ContainsKey(mision.Nombre))
            {
                return false;
            }
            else
            {
                Misiones[mision.Nombre] = mision;
                return true;
            }
        }
    }
}
