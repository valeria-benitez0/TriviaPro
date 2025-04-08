using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wTriviaPro
{
    public class PreguntaDificil : Pregunta
    {
        public PreguntaDificil(string texto, List<string> opciones, string respuestaCorrecta, string categoria)
            : base(texto, opciones, respuestaCorrecta, categoria, "Difícil") { }

        public override int EvaluarRespuesta(string respuestaUsuario)
        {
            return respuestaUsuario == RespuestaCorrecta ? 15 : -2;
        }
    }
}
