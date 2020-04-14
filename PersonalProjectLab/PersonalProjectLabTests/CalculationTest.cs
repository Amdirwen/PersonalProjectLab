using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void Calculations_Inertia()
        {
            //arrange
            calculations calculations = new calculations();

            //act
            decimal inertia = calculations.CalculateInertia(4, 3);

            //assert
            Assert.AreEqual(9.00m, inertia);
        }
        [TestMethod]
        public void Calculations_Deflection()
        {
            //arrange
            calculations calculations = new calculations();

            //act
            decimal deflection = calculations.CalculateDeflection(100, 100, 1800000, 9);

            //assert
            Assert.AreEqual((decimal)0.1286M, deflection);
        }

    }   
}   

