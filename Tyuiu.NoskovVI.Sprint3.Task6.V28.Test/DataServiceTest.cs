using Tyuiu.NoskovVI.Sprint3.Task6.V28.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DivisorsTest()
        {
            DataService ds = new DataService();
            int startValue = 13;
            int endValue = 19;
            int wait = 15;
            Assert.AreEqual(wait, ds.GetSumTheDivisors(startValue, endValue));
        }
    }
}