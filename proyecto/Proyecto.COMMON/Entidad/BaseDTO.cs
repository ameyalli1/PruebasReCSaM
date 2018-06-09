using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.COMMON.Entidad
{
    public class BaseDTO
    {
        public ObjectId Id { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
