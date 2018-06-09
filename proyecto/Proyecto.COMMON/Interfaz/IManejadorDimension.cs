using Proyecto.COMMON.Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Interfaz
{
    public interface IManejadorDimension : IManejadorGenerico<Dimension>
    {
        IEnumerable BuscarDimension(string Dimensiones);
        IEnumerable BuscarMismaEmpresa(string Empresas);
    }
}
