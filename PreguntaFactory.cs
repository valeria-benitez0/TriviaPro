using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wTriviaPro
{
    public static class PreguntaFactory
    {
        private static List<Pregunta> preguntasDisponibles = new List<Pregunta>();

        private static Random random = new Random();

        static PreguntaFactory()
        {
            // Aquí agregamos preguntas simuladas
            preguntasDisponibles.Add(new PreguntaFacil("¿Cuál es la capital de Francia?", new List<string> { "Madrid", "París", "Roma" }, "París", "Cultura-General"));
            preguntasDisponibles.Add(new PreguntaMedia("¿Quién propuso la teoría de la relatividad?", new List<string> { "Newton", "Einstein", "Tesla" }, "Einstein", "Ciencia"));
            preguntasDisponibles.Add(new PreguntaDificil("¿En qué año cayó Constantinopla?", new List<string> { "1453", "1492", "1521" }, "1453", "Historia"));

            // Repetimos y variamos para simular más
            preguntasDisponibles.Add(new PreguntaFacil("¿Qué planeta es conocido como el planeta rojo?", new List<string> { "Venus", "Marte", "Júpiter" }, "Marte", "Ciencia"));
            preguntasDisponibles.Add(new PreguntaMedia("¿En qué siglo vivió Napoleón Bonaparte?", new List<string> { "XV", "XVI", "XIX" }, "XIX", "Historia"));
            preguntasDisponibles.Add(new PreguntaDificil("¿Cuál es el elemento número 79 en la tabla periódica?", new List<string> { "Oro", "Plomo", "Mercurio" }, "Oro", "Ciencia"));
        }

        public static List<Pregunta> ObtenerPreguntas(string categoria, string nivel, int cantidad)
        {
            var filtradas = preguntasDisponibles
                .Where(p => p.Categoria == categoria && p.Nivel == nivel)
                .OrderBy(x => random.Next())
                .Take(cantidad)
                .ToList();

            if (filtradas.Count < cantidad)
                throw new Exception("No hay suficientes preguntas disponibles para esa categoría y nivel.");

            return filtradas;
        }
    }
}
