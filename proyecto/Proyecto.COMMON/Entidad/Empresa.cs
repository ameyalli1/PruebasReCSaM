using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Entidad
{
    public class Empresa:BaseDTO
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
