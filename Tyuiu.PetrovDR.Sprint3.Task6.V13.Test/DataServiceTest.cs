using Tyuiu.PetrovDR.Sprint3.Task6.V13.Lib;

namespace Tyuiu.PetrovDR.Sprint3.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 8;
            int stopValue = 17;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 117;

            Assert.AreEqual(wait, res);
        }
    }
}
