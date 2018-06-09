using Proyecto.COMMON.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Modelos
{
    public class ModeloUsuarios
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Turno { get; set; }
        public string Horario { get; set; }
        public ModeloUsuarios(Encuestador meseros) {
            Nombre = string.Format("{0} {1}", meseros.Nombres, meseros.Apellidos);
            Correo = string.Format("{0}", meseros.Correo);
            Turno = string.Format("{0}", meseros.Turno);
            Horario = string.Format("{0}", meseros.Horario);
        }
    }
}
