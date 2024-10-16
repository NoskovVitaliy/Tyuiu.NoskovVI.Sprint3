using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NoskovVI.Sprint3.Task1.V28.Lib
{
    public class DataService : ISprint3Task1V28
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double Sum = 0;
            double a = value;
            int k = startValue;
            while (k <= stopValue)
            {
                Sum += ((Math.Pow(a, k) + 0.25) * (double)Math.Cos(k));
                k++;
            }
            return Math.Round(Sum,3);
                    

        }
    }
}
