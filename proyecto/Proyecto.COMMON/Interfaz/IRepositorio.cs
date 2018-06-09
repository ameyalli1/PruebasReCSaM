using MongoDB.Bson;
using Proyecto.COMMON.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Interfaz
{
    public interface IRepositorio<T> where T:BaseDTO
    {
        bool Create(T entidad);
        List<T> Read { get; }
        bool Update(T entidad);
        bool Delete(ObjectId id);
        
    }
}
