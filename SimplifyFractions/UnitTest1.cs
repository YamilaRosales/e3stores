using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FraccionesLib;

namespace SimplifyFractionsTest
{
    [TestClass]
    public class SimplificarTest
    {
        [TestMethod]
        public void SimplificarFracciones()
        {
            var f = new Fracciones();
            f.Simplificar("4/6");
            f.Simplificar("10/11");
            f.Simplificar("100/400");
        }
    }
}
