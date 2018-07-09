using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;

namespace EntidadesTest
{
    [TestClass]
    public class EntidadesTest
    {
        /// <summary>
        /// Realizar un test que compruebe que si hay un error al querer serializar un objeto del tipo Votacion
        /// lance la excepción ErrorArchivoException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException))]
        public void lanzarErrorBinario()
        {
            // arrange  
            Dictionary<string, Votacion.EVoto> senadores = new Dictionary<string, Votacion.EVoto>();            
            senadores.Add("Senador 1", Votacion.EVoto.Afirmativo);
            senadores.Add("Senador 2", Votacion.EVoto.Negativo);
            senadores.Add("Senador 3", Votacion.EVoto.Abstencion);
            senadores.Add("Senador 4", Votacion.EVoto.Afirmativo);          
            Votacion votacion = new Votacion("Ley 1", senadores);
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string nombreArchivoBinario = folder + "votacionesTest.dat";
            string  nombreArchivoBinario = "";
            SerializarBinaria ser = new SerializarBinaria();
            // act              
            ser.Guardar(nombreArchivoBinario, votacion);
            // assert es manejado en el ExpectedException  
        }

        [TestMethod]
        public void escribirDB()
        {
            // arrange  
            Dictionary<string, Votacion.EVoto> senadores = new Dictionary<string, Votacion.EVoto>();
            senadores.Add("Senador 1", Votacion.EVoto.Afirmativo);
            senadores.Add("Senador 2", Votacion.EVoto.Negativo);
            senadores.Add("Senador 3", Votacion.EVoto.Abstencion);
            senadores.Add("Senador 4", Votacion.EVoto.Afirmativo);
            Votacion votacion = new Votacion("Ley 1", senadores);
            // act              
            Dao d = new Dao();
            d.Guardar("Votaciones", votacion);
        }


        [TestMethod]
        public void escribirArchivo()
        {
            // arrange  
            Dictionary<string, Votacion.EVoto> senadores = new Dictionary<string, Votacion.EVoto>();
            senadores.Add("Senador 1", Votacion.EVoto.Afirmativo);
            senadores.Add("Senador 2", Votacion.EVoto.Negativo);
            senadores.Add("Senador 3", Votacion.EVoto.Abstencion);
            senadores.Add("Senador 4", Votacion.EVoto.Afirmativo);
            Votacion votacion = new Votacion("Ley 1", senadores);
            // act    
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreArchivoBinario = folder + "\\votacionesTest.dat";
            SerializarBinaria ser = new SerializarBinaria();
            ser.Guardar(nombreArchivoBinario, votacion);
        }

        //Realizar un test que compruebe que el evento de la clase Votacion tantas veces como Senadores
        //haya. O sea, si hay 2 senadores el evento será invocado 2 veces.

        [TestMethod]
        public void cantidadDeEventos()
        {
            // arrange  
            Dictionary<string, Votacion.EVoto> senadores = new Dictionary<string, Votacion.EVoto>();
            senadores.Add("Senador 1", Votacion.EVoto.Afirmativo);
            senadores.Add("Senador 2", Votacion.EVoto.Negativo);
            Votacion votacion = new Votacion("Ley 1", senadores);
            this.cantidadInvocaciones = 2;
            short expected = 0;
            votacion.EventoVotoEfectuado += TestEvento;            
            // act              
            votacion.Simular();
            // assert es manejado en el ExpectedException  
            Assert.AreEqual(expected, this.cantidadInvocaciones);
        }

        private short cantidadInvocaciones;        
        public void TestEvento(string senador, Votacion.EVoto voto)
        {
            this.cantidadInvocaciones--;            
        }

    }
}
