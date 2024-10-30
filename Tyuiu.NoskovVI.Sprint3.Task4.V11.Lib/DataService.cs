using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NoskovVI.Sprint3.Task4.V11.Lib
{
    public class DataService : ISprint3Task4V11

    {
        public double Calculate(int startValue, int stopValue)
        {
            double multiplication = 1;
            for (int x = startValue;  x <= stopValue; x++)
            {
                if (x == 0) continue;
                multiplication *= ((double)x) / ((Math.Sin((double)x) - (double)x) + 2d);
            }
            return Math.Round(multiplication, 3);
        }
    }
}
