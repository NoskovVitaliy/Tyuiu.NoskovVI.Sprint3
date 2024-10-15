using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NoskovVI.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double endResult = 1;
            for ( int i = startValue; i < stopValue+1; i++)
            {
                endResult *= ((Math.Pow(value, 3) * (double)i) + 2d);
            }
            return Math.Round(endResult,3);
        }
    }
}
