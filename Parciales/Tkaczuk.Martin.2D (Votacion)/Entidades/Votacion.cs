using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    [Serializable]
    public class Votacion
    {
        public delegate void Voto(string senador, Votacion.EVoto voto);
        
        [field: NonSerializedAttribute()]
        public event Voto EventoVotoEfectuado;
        
        public enum EVoto { Afirmativo, Negativo, Abstencion, Esperando }

        private string nombreLey;
        private Dictionary<string, EVoto> senadores;

        private short contadorAfirmativo;
        private short contadorNegativo;
        private short contadorAbstencion;

        public short Afirmativos 
        {
            get 
            {
                return contadorAfirmativo;
            }
        }

        public short Negativos
        {
            get
            {
                return contadorNegativo;
            }
        }

        public short Abstencion
        {
            get
            {
                return contadorAbstencion;
            }
        }

        public string NombreLey
        {
            get
            {
                return nombreLey; 
            }
        }

        public Votacion(string nombreLey, Dictionary<string, EVoto> senadores)
        {
            this.nombreLey = nombreLey;
            this.senadores = senadores;
        }

             
        public void Simular()
        {
            // Reseteo contadores
            this.contadorAbstencion = 0;
            this.contadorAfirmativo = 0;
            this.contadorNegativo = 0;
            // Itero todos los Senadores
            for (int index = 0; index < this.senadores.Count; index++)
            {
                // Duermo el hilo
                System.Threading.Thread.Sleep(2134);

                // Leo el senador actual
                KeyValuePair<string, EVoto> k = this.senadores.ElementAt(index);
                // Generador de número aleatorio
                Random r = new Random(k.Key.ToString().Length + DateTime.Now.Millisecond);
                // Modifico el voto de forma aleatoria
                this.senadores[k.Key]  = (EVoto)r.Next(0, 3);                

                // Invocar Evento
                this.EventoVotoEfectuado(k.Key, this.senadores[k.Key]);
                // Incrementar contadores                
                switch (this.senadores[k.Key])
                {
                    case Votacion.EVoto.Afirmativo:                         
                        this.contadorAfirmativo ++ ;            
                    break;
                    case Votacion.EVoto.Abstencion:
                        this.contadorAbstencion ++;
                    break;
                    case Votacion.EVoto.Negativo:
                        this.contadorNegativo ++;
                    break;
                }
            }
        }
    }
}
