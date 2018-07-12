using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(GrupoLlenoException))]
        public void ValidacionOperadorSumarEquipo()
        {
            Grupo grupoNuevo = new Grupo(Letras.A, 4);
            Equipo nuevoEquipo = new Equipo(99, "Italia");
            grupoNuevo = grupoNuevo + nuevoEquipo;            
        }
    }
}
