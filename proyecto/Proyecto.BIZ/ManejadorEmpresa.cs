using MongoDB.Bson;
using Proyecto.COMMON.Entidad;
using Proyecto.COMMON.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto.BIZ
{
    public class ManejadorEmpresa : IManejadorEmpresa
    {        
        IRepositorio<Empresa> empresa;

        public ManejadorEmpresa(IRepositorio<Empresa> empresa)
        {
            this.empresa = empresa;
        }
        public List<Empresa> Lista => empresa.Read.OrderBy(p => p.Nombre).ToList();

        public bool Agregar(Empresa entidad)
        {
            return empresa.Create(entidad);
        }

        public Empresa Buscador(ObjectId id)
        {
            return Lista.Where(e => e.Id == id).SingleOrDefault();
        }

        public int BuscarUsuario(string password, string Empresa)
        {
            int valor = 0;
            foreach (var item in empresa.Read)
            {
                if (item.Nombre == Empresa && item.Password == password)
                {
                     valor =valor+1;
                }
            }
            return valor;
        }

        public bool Eliminar(ObjectId id)
        {
            return empresa.Delete(id);
        }

        public bool Modificar(Empresa entidad)
        {
            return empresa.Update(entidad);
        }    
    }
}
