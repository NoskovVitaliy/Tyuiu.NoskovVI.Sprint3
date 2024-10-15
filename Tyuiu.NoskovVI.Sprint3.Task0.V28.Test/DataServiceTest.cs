using Tyuiu.NoskovVI.Sprint3.Task0.V28.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MultiplySeriesTest()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int endValue = 17;
            double wait = 411589.537;
            Assert.AreEqual(wait, ds.GetMultiplySeries(value, startValue, endValue)); 
        }
    }
}