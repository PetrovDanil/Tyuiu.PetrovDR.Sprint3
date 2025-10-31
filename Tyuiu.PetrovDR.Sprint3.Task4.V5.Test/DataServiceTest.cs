using Tyuiu.PetrovDR.Sprint3.Task4.V5.Lib;

namespace Tyuiu.PetrovDR.Sprint3.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = -0.858;

            Assert.AreEqual(wait, res);
        }
    }
}
