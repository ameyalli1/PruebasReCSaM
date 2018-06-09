using Proyecto.COMMON.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Interfaz
{
    public interface IManejadorEmpresa : IManejadorGenerico<Empresa>
    {
        int BuscarUsuario(string password, string Empresa);
    }
}
