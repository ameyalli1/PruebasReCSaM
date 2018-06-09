using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Entidad
{
    public class Respuesta : BaseDTO
    {
        public string IdEncuesta { get; set; }
        public string IdPregunta { get; set; }
        public string Respuestas { get; set; }//la cambie por que algunas son string
        public string Encuestador { get; set; }
        public List<DatosFotografia> Fotografia { get; set; }
        public string Empresas { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }

    }
}
