using Proyecto.COMMON.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Modelos
{
    public class ModeloEncuestas
    {
        public string Fecha { get; set; }
        public string IdEncuesta { get; set; }
        public string IdPregunta { get; set; }
        public string Encuestador { get; set; }
        public string Respuesta { get; set; }
        public List<DatosFotografia> DatosFotografia { get; set; }
        public ModeloEncuestas(Respuesta respuesta)
        {
            Fecha = string.Format("{0}", respuesta.FechaHora.ToString());
            IdEncuesta = string.Format("{0} ", respuesta.IdEncuesta);
            IdPregunta = string.Format("{0}", respuesta.IdPregunta);
            Encuestador = string.Format("{0}", respuesta.Encuestador);
            Respuesta = string.Format("{0}", respuesta.Respuestas);
        }
    }
}
