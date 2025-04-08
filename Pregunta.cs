using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wTriviaPro
{
    public abstract class Pregunta
    {
        // Propiedades
        public string Texto { get; protected set; }
        public List<string> Opciones { get; protected set; }
        public string RespuestaCorrecta { get; protected set; }
        public string Categoria { get; protected set; }
        public string Nivel { get; protected set; }

        // Constructor
        protected Pregunta(string texto, List<string> opciones, string respuestaCorrecta, string categoria, string nivel)
        {
            if (string.IsNullOrWhiteSpace(categoria)) throw new ArgumentException("Categoría no puede estar vacía.");
            if (opciones == null || opciones.Count < 2) throw new ArgumentException("Debe haber al menos dos opciones.");

            Texto = texto;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
            Categoria = categoria;
            Nivel = nivel;
        }

        // Método polimórfico
        public abstract int EvaluarRespuesta(string respuestaUsuario);
    }
}
