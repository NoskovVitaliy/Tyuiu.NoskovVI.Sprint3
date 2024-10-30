using Tyuiu.NoskovVI.Sprint3.Task5.V26.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumTest()
        {
            DataService ds = new DataService();
            int x = 2;
            int start1 = 1;
            int start2 = 1;
            int end1 = 3;
            int end2 = 13;
            double wait = 49146.884;
            Assert.AreEqual(wait, ds.GetSumSumSeries(x, start1, start2, end1, end2));
        }
    }
}