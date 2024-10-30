using Tyuiu.NoskovVI.Sprint3.Task7.V23.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MassTest()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            int len = end - start + 1;
            double[] wait = new double[len];
            wait[0] = 13.81;
            wait[1] = 11.87;
            wait[2] = 9.87;
            wait[3] = 7.74;
            wait[4] = 5.36;
            wait[5] = 2.50;
            wait[6] = 0;
            wait[7] = 0.79;
            wait[8] = -1.75;
            wait[9] = -3.78;
            wait[10] = -5.71;
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(start, end));
        }
    }
}