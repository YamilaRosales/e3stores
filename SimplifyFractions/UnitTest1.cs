using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace SimplifyFractionsTest
{
    [TestClass]
    public class SimplificarTest    
    {
        [TestMethod]
        public void SimplificarFracciones()
        {
            Simplificar("4/6");
            Simplificar("10/11");
            Simplificar("100/400")
        }
    }
}
