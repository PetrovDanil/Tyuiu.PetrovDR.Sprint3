using Tyuiu.PetrovDR.Sprint3.Task5.V5.Lib;

namespace Tyuiu.PetrovDR.Sprint3.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 98.286;

            Assert.AreEqual(wait, res);
        }
    }
}
