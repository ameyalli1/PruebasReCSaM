using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Entidad
{
    public class Encuestador:Usuario
    {
        public string Horario { get; set; }
        public string Turno { get; set; }
        public override string ToString()
        {
            return Nombres;
        }
    }
}
