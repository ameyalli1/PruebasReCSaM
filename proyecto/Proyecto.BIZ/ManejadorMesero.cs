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
    public class ManejadorMesero:IManejadorMesero
    {
        IRepositorio<Encuestador> meseros;

        public ManejadorMesero(IRepositorio<Encuestador> mesero)
        {
            this.meseros = mesero;
        }
        public List<Encuestador> Lista => meseros.Read.OrderBy(p => p.Nombres).ToList();

        public bool Agregar(Encuestador entidad)
        {
            return meseros.Create(entidad);
        }

        public Encuestador Buscador(ObjectId id)
        {
            return Lista.Where(e => e.Id == id).SingleOrDefault();
        }

        public IEnumerable BuscarEmpresaUsuario(Empresa empresa)
        {
            return meseros.Read.Where(p => p.Empresa == empresa.Nombre).OrderBy(p => p.Apellidos);
        }

        public string BuscarIDentificador(String ID)
        {
            string IDentificador = "";
            foreach (var item in meseros.Read)
            {
                if (item.Nombres==ID) {
                    IDentificador = item.Nombres;
                }
            }
            return IDentificador;
        }

        

        public int BuscarUsuario(string Empresa, string usuario, string contrasena)
        {
            int valor = 0;
            valor = (meseros.Read.Where(p => p.Empresa == Empresa && p.Nombres == usuario && p.Password == contrasena)).Count();
            return 1;
        }

        public IEnumerable BuscarUsuarioEspecifico(string Nombre, string Empresa)
        {
            return meseros.Read.Where(e => e.Nombres == Nombre || e.Apellidos==Nombre && e.Empresa == Empresa);//checar
        }

        public IEnumerable BuscarUsuariosEmpresa(string Empresa)
        {          
           
           return meseros.Read.Where(e => e.Empresa != Empresa.ToString());
            // return meseros.Lista.Where(e => e.Empresa != Empresa);//checar por que no me respeta eso
        }

        public bool Eliminar(ObjectId id)
        {
            return meseros.Delete(id);
        }

        public bool Modificar(Encuestador entidad)
        {
            return meseros.Update(entidad);
        }
    }
}
