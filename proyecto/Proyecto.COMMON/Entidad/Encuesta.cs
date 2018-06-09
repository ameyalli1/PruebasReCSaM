using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Entidad
{
    public class Encuesta:BaseDTO
    {
        public string Nombre { get; set; }
        public string Duenio { get; set; }
        public string Objetivo { get; set; }
        public List<ClaseGeneral> MostrarPreguntasAleatoriamente { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
