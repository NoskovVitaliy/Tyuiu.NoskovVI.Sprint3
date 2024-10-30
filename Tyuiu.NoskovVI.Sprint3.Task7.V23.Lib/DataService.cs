using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NoskovVI.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] funcresult = new double[stopValue - startValue + 1];
            int index = 0;
            double function;
            for (int x = startValue;  x <= stopValue; x++)
            {
                if (x == 1) { funcresult[index] = 0; index++; continue; }
                function = 4 - 2 * x + ((2 + Math.Cos(x)) / (2 * x - 2));
                funcresult[index] = Math.Round(function,2);
                index++;
            }
            return funcresult;
        }
    }
}
