using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NoskovVI.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiply = 1;
            do
            {
                multiply *= (Math.Pow(value, (double)startValue) + 1d) * Math.Cos(4d);
                startValue++;

            } while (startValue<=stopValue);
            return Math.Round(multiply,3);
        }
    }
}
