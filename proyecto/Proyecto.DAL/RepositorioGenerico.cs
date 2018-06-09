using MongoDB.Bson;
using MongoDB.Driver;
using Proyecto.COMMON.Entidad;
using Proyecto.COMMON.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.DAL
{
    public class RepositorioGenerico<T> : IRepositorio<T> where T : BaseDTO
    {
        private MongoClient client;
        private IMongoDatabase db;

        public RepositorioGenerico()
        {
            client = new MongoClient(new MongoUrl("mongodb://daniela:daniela@ds133550.mlab.com:33550/proyecto"));
            db = client.GetDatabase("proyecto");//nombre de mi base de datos

        }
        private IMongoCollection<T> Collection()
        {
            return db.GetCollection<T>(typeof(T).Name);
        }

        public List<T> Read => Collection().AsQueryable().ToList();

        public bool Create(T entidad)
        {
            try
            {
                Collection().InsertOne(entidad);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T entidad)
        {
            try
            {
                return Collection().ReplaceOne(p => p.Id == entidad.Id, entidad).ModifiedCount == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(ObjectId id)
        {
            try
            {
                return Collection().DeleteOne(p => p.Id == id).DeletedCount == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
      
        
        /*<T>:IRepositorio<T> where T: BaseDTO
    {
        private MongoClient client;
        private IMongoDatabase db;
        public RepositorioGenerico()
        {
            client = new MongoClient(new MongoUrl("mongodb://laujos:ghat5lth99@ds245337.mlab.com:45337/proyecto"));
            db = client.GetDatabase("proyecto");//nombre de mi base de datos
        }

        private IMongoCollection<T> Collection()
        {
            return db.GetCollection<T>(typeof(T).Name);
        }

        public List<T> Lista => Collection().AsQueryable().ToList();

        public bool Crear(T entidad)
        {
            try
            {
                Collection().InsertOne(entidad);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Editar(T entidad)
        {
            try
            {
                return Collection().ReplaceOne(p => p.Id == entidad.Id, entidad).ModifiedCount == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(ObjectId Id)
        {
            try
            {
                return Collection().DeleteOne(p => p.Id == Id).DeletedCount == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }*/
   // }
//}
