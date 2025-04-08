using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wTriviaPro
{
    public class PreguntaMedia : Pregunta
    {
        public PreguntaMedia(string texto, List<string> opciones, string respuestaCorrecta, string categoria)
            : base(texto, opciones, respuestaCorrecta, categoria, "Medio") { }

        public override int EvaluarRespuesta(string respuestaUsuario)
        {
            return respuestaUsuario == RespuestaCorrecta ? 10 : -2;
        }
    }
}
