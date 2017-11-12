using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjemploUnitTesting;

namespace ProyectoDePruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CrearMundo1()
        {
            //arrange | arreglar
            var c = new Genio();

            //act | actuar
            var r = c.CrearMundo(1);

            //assert | afirmar
            Assert.AreEqual("Mundo Magico", r);
        }

        [TestMethod]
        public void CrearMundo2()
        {
            //arrange | arreglar
            var c = new Genio();

            //act | actuar
            var r = c.CrearMundo(1);

            //assert | afirmar
            Assert.AreEqual("Mundo Magico", r);
        }

        [TestMethod]
        public void CrearMundo3()
        {
            //arrange | arreglar
            var c = new Genio();

            //act | actuar
            var r = c.CrearMundo(1);

            //assert | afirmar
            Assert.AreEqual("Mundo Magico", r);
        }

        [TestMethod]
        public void ThrowException()
        {
            //arrange | arreglar
            var c = new Genio();

            //act | actuar
            c.ThrowException();

            //assert | afirmar
            Assert.AreEqual(true, c.Bandera);
        }

    }
}
