using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Entidad
{
    public class Dimension:BaseDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string NombreEmpresa { get; set; }
        public override string ToString()
        {
            return Nombre; 
        }
    }
}
