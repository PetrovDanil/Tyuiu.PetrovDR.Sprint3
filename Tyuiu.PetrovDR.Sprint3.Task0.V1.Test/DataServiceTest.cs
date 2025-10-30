using Tyuiu.PetrovDR.Sprint3.Task0.V1.Lib;

namespace Tyuiu.PetrovDR.Sprint3.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 4;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 1935;

            Assert.AreEqual(wait, res);
        }
    }
}
