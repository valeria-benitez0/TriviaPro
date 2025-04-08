using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wTriviaPro
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public Puntaje Puntaje { get; private set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Puntaje = new Puntaje();
        }

        public void ReiniciarPuntaje()
        {
            Puntaje = new Puntaje();
        }
    }
}
