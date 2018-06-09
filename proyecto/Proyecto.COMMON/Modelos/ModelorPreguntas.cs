using Proyecto.COMMON.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Modelos
{
    public class ModelorPreguntas
    {
        string respuesta = "";
        public string Pregunta { get; set; }
        public string Respuestas { get; set; }
        public ModelorPreguntas(Pregunta pregunta) {
            Pregunta = string.Format("{0}", pregunta.Texto);
            foreach (var item in pregunta.Respuestas)
            {
                respuesta += item.Datos+ "\n"; 
            }
            Respuestas = string.Format("{0}", respuesta);
        }
    }
}
