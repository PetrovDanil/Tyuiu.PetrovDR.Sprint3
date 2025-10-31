using Tyuiu.PetrovDR.Sprint3.Task3.V15.Lib;

namespace Tyuiu.PetrovDR.Sprint3.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();

            string str = "lrmmse mg sermmmrt";
            char chr = 'm';

            int res = ds.GetMinCharCount(str, chr);
            int wait = 2;

            Assert.AreEqual(wait, res);

        }
    }
}