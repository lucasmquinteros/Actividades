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
        //actividad 3: implementar un metodo agregar jugador que si ya existe el jugador retornar false, sino por cada mision el jugador intentara superar
        //y se le incrementaran los puntos de experiencia, de acuerdo a los puntos de la mision
        public bool addJugador(Jugador jugador)
        {
            if(Jugadores.Contains(jugador)) return false;
            foreach (Mision m in Misiones.Values) {
                if (jugador.addMisionSuperada(m.Nombre))
                {
                    jugador.incrementarPuntosDeExperiencia(m.getPuntosEXRecompensa());
                }
            }
            return true;
        }
        //implementar un metodo sin nombre, donde sus variables no tienen nombres tampoco y conocer para que sirven
        public List<string> getMisionesNoSuperadas()
        {
            List<string> misiones = new List<string>();
            foreach (Mision m in Misiones.Values)
            {
                bool IsCompleta = false;
                foreach (Jugador j in Jugadores)
                {
                    if (m.superaMision(j))
                    {
                        IsCompleta = true;
                    }
                    if (!IsCompleta) { 
                        misiones.Add(m.Nombre);
                    }
                }
            }
            return misiones;
        }

    }
}
