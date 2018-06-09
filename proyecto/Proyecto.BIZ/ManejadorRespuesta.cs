using MongoDB.Bson;
using Proyecto.COMMON.Entidad;
using Proyecto.COMMON.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto.BIZ
{
    public class ManejadorRespuesta:IManejadorRespuesta
    {
        IRepositorio<Respuesta> respuesta;

        public ManejadorRespuesta(IRepositorio<Respuesta> respuesta)
        {
            this.respuesta = respuesta;
        }
        public List<Respuesta> Lista => respuesta.Read.OrderBy(p => p.Id).ToList();

        public bool Agregar(Respuesta entidad)
        {
            return respuesta.Create(entidad);
        }

        public Respuesta Buscador(ObjectId id)
        {
            return Lista.Where(e => e.Id == id).SingleOrDefault();
        }

        public bool Eliminar(ObjectId id)
        {
            return respuesta.Delete(id);
        }

        public bool Modificar(Respuesta entidad)
        {
            return respuesta.Update(entidad);
        }
    }
}
