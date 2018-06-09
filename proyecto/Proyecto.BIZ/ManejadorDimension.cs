using MongoDB.Bson;
using Proyecto.COMMON.Entidad;
using Proyecto.COMMON.Interfaz;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto.BIZ
{
    public class ManejadorDimension : IManejadorDimension
    {
        IRepositorio<Dimension> dimension;

        public ManejadorDimension(IRepositorio<Dimension> dimension)
        {
            this.dimension = dimension;
        }
        public List<Dimension> Lista => dimension.Read.OrderBy(p => p.Nombre).ToList();

        public bool Agregar(Dimension entidad)
        {
            return dimension.Create(entidad);
        }

        public Dimension Buscador(ObjectId id)
        {
            return Lista.Where(e => e.Id == id).SingleOrDefault();
        }

        public IEnumerable BuscarDimension(string Dimensiones)
        {
            return dimension.Read.Where(e => e.Nombre != Dimensiones).ToList();//checar esta parte
        }

        public IEnumerable BuscarMismaEmpresa(string Empresas)
        {
            return dimension.Read.Where(e => e.NombreEmpresa != Empresas).ToList();//checar esta parte
        }

        public bool Eliminar(ObjectId Id)
        {
            return dimension.Delete(Id);
        }

        public bool Modificar(Dimension entidad)
        {
            return dimension.Update(entidad);
        }
    }

}
