using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Entidad
{
    public class Pregunta : BaseDTO
    {
        public string IdEncuesta { get; set; }
        public string Texto { get; set; }
        public List<ClaseGeneral> Respuestas { get; set; }
        public string ValorMinimo { get; set; }
        public string ValorMaximo { get; set; }
        public string Dimension { get; set; }
        public override string ToString()
        {
            return Respuestas + "\n"; 
        }
    }
}
