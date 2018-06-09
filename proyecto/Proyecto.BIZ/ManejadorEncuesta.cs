using MongoDB.Bson;
using Proyecto.COMMON.Entidad;
using Proyecto.COMMON.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto.BIZ
{
    public class ManejadorEncuesta:IManejadorEncuesta
    {
        IRepositorio<Encuesta> encuesta;

        public ManejadorEncuesta(IRepositorio<Encuesta> encuesta)
        {
            this.encuesta = encuesta;
        }
        public List<Encuesta> Lista => encuesta.Read.OrderBy(p => p.FechaHora).ToList();

        public bool Agregar(Encuesta entidad)
        {
            return encuesta.Create(entidad);
        }

        public Encuesta Buscador(ObjectId id)
        {
            return Lista.Where(e => e.Id == id).SingleOrDefault();//falta checar si si son los datos a tomar
        }

        public bool Eliminar(ObjectId id)
        {
            return encuesta.Delete(id);
        }

        public bool Modificar(Encuesta entidad)
        {
            return encuesta.Update(entidad);
        }
    }
}
