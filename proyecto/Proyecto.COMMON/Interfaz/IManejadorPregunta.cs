using MongoDB.Bson;
using Proyecto.COMMON.Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Interfaz
{
    public interface IManejadorPregunta : IManejadorGenerico<Pregunta>
    {
        bool VerificarSiEsNumero(string cadena);
        int ContarPosicion(string datos, ObjectId Id);
        IEnumerable BuscarDimensionEspecifico(string Dimension, string Empresa);
        //  void ContarPosicion(List<ClaseGeneral> respuestas, string id);
    }
}
