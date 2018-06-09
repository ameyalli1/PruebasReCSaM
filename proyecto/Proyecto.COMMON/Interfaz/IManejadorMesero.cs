using MongoDB.Bson;
using Proyecto.COMMON.Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Interfaz
{
    public interface IManejadorMesero : IManejadorGenerico<Encuestador>
    {
        int BuscarUsuario(string Empresa, string usuario, string contrasena);
        IEnumerable BuscarUsuariosEmpresa(string empresa);
        IEnumerable BuscarUsuarioEspecifico(string Nombre, string Empresa);
        IEnumerable BuscarEmpresaUsuario(Empresa empresa);
        string BuscarIDentificador(string ID);
        //  void BuscarUsuariosEmpresa(string Empresa);
        //T Buscador(string Id);
    }
}
