using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Excepciones;

namespace Entidades
{
    public class SerializarBinaria : IArchivos<Votacion>
    {
        public  Votacion Leer(string nombre)
        {                
            try
            {
                Votacion votacionLeida;
                //contenidos en el archivo binario.
                FileStream fs;                  //Objeto que leerá en binario.
                BinaryFormatter ser;      //Objeto que Deserializará.
                fs = new FileStream(nombre, FileMode.Open);
                //Se indica ubicación del archivo binario y el modo.
                ser = new BinaryFormatter();
                //Se crea el objeto deserializador.
                votacionLeida = (Votacion)ser.Deserialize(fs);
                //Deserializa el archivo contenido en fs, lo guarda 
                //en aux.
                fs.Close();
                return votacionLeida;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException("Error al intentar escribir el archivo ", e);
            }
        }

        public  bool Guardar(string nombre, Votacion objeto)
        {
            //TODO revisar si es lo que se busca
            bool todoOk = true;
            try
            {
                FileStream fs;  	  //Objeto que escribirá en binario.
                BinaryFormatter ser;  //Objeto que serializará.

                fs = new FileStream(nombre, FileMode.Create);
                //Se indica ubicación del archivo binario y el modo.
                ser = new BinaryFormatter();
                //Se crea el objeto serializador.
                ser.Serialize(fs, objeto);
                //Serializa el objeto p en el archivo contenido en fs.
                fs.Close();
                //Se cierra el objeto fs.
            }
            catch (Exception e)            
            {
                todoOk = false;
                throw new ErrorArchivoException("Error al intentar escribir el archivo ", e);            
            }            
            return todoOk;
        }
    }
}
