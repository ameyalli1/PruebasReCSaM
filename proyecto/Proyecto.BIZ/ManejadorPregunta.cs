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
    public class ManejadorPregunta:IManejadorPregunta
    {
        IRepositorio<Pregunta> pregunta;

        public ManejadorPregunta(IRepositorio<Pregunta> pregunta)
        {
            this.pregunta = pregunta;
        }
        public List<Pregunta> Lista => pregunta.Read.OrderBy(p => p.FechaHora).ToList();

        public bool Agregar(Pregunta entidad)
        {
            return pregunta.Create(entidad);
        }

        public Pregunta Buscador(ObjectId id)
        {
            return Lista.Where(e => e.Id == id).SingleOrDefault();
        }

        public IEnumerable BuscarDimensionEspecifico(string Dimension, string Empresa)
        {
            return pregunta.Read.Where(e => e.Dimension == Dimension );//falta agregar la empresa
        }

        public int ContarPosicion(string datos, ObjectId ID)
        {
            int contador = 0;
            int puntuacion = 0;
           // int puntacionFinal = 0;
            int limites=0;
            foreach (var item in pregunta.Read)
            {
                if (item.Id==ID) {
                    int NumRespuestas = item.Respuestas.Count;//contador de Respuestas//
                     limites = (int.Parse(item.ValorMaximo) - int.Parse(item.ValorMinimo)) / NumRespuestas;
                    foreach (var item2 in item.Respuestas)
                    {
                        contador++;
                        if (item2.Datos==datos) {
                            puntuacion = contador;
                        }
                    }
                }
            }
            return limites * puntuacion;
        }

        /*public void ContarPosicion(List<ClaseGeneral> respuestas, string id)
        {
            foreach (var item in pregunta.Lista)
            {
                if (item.Id==id) { }
            }
            /*foreach (var item in pregunta.Lista)
            {
                if (item.Id==id) {
                    int NumRespuestas=item.Respuestas.Count;//contador de Respuestas//
                    int Limites = (int.Parse(item.ValorMaximo) - int.Parse(item.ValorMinimo))/NumRespuestas;//para dividir la cantidad de puntos que vale cada respuestas 
                                                                                                            //contador de Preguntas
                    foreach (var item2 in item.Respuestas)
                    {
                        if (item2.Datos==respuestas) { }
                    }
                }
            }
        }*/

        public bool Eliminar(ObjectId id)
        {
            return pregunta.Delete(id);
        }

        public bool Modificar(Pregunta entidad)
        {
            return pregunta.Update(entidad);
        }

        public bool VerificarSiEsNumero(string cadena)
        {
            foreach(var item in cadena)
            {
                if (!(char.IsNumber(item)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
