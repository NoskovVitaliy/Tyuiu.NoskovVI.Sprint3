using Tyuiu.NoskovVI.Sprint3.Task1.V28.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SeriesSumTest()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int endValue = 18;
            double wait = -0.186;
            Assert.AreEqual(wait, ds.GetSumSeries(value, startValue, endValue));
        }
    }
}