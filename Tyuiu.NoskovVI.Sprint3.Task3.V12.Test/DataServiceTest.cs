using Tyuiu.NoskovVI.Sprint3.Task3.V12.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MaxCharCountTest()
        {
            DataService ds = new DataService();
            string value = "bkkrk ckkkcs ksr";
            char item = 'k';
            int wait = 3;
            Assert.AreEqual(wait, ds.GetMaxCharCount(value, item));
        }
    }
}