using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Entidad
{
    public class ClaseGeneral
    {
        public string Datos { get; set; }
        public override string ToString()
        {
            return Datos+ "\n";     
        }
    }
}
