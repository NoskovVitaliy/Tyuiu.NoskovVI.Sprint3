using Tyuiu.NoskovVI.Sprint3.Task4.V11.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double wait = 0.526;
            Assert.AreEqual(wait, ds.Calculate(start, end));
        }
    }
}