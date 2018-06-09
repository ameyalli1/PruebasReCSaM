using MongoDB.Bson;
using Proyecto.COMMON.Entidad;
using Proyecto.COMMON.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto.BIZ
{
    public class ManejadorDatosFotografia:IManejadorFotografia
    {
        IRepositorio<DatosFotografia> datosFotografia;

        public ManejadorDatosFotografia(IRepositorio<DatosFotografia> datosFotografia)
        {
            this.datosFotografia = datosFotografia;
        }
        //cambia la lista en el min 25
        public List<DatosFotografia> Lista => datosFotografia.Read;

        public bool Agregar(DatosFotografia entidad)
        {
            return datosFotografia.Create(entidad);
        }

        public DatosFotografia Buscador(ObjectId id) { 
            return Lista.Where(e => e.Id == id).SingleOrDefault();//falta checar si si son los datos a tomar
        }

        public bool Eliminar(ObjectId id)
        {
            return datosFotografia.Delete(id);
        }

        public bool Modificar(DatosFotografia entidad)
        {
            return datosFotografia.Update(entidad);
        }
    }
}
