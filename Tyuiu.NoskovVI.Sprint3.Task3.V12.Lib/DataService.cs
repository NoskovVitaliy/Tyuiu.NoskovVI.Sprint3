using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NoskovVI.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            bool previousSymbol = false;
            int maxCount = 0;
            foreach (char c in value)
            {
                if (c == item && previousSymbol == true) count++;
                if (c == item && previousSymbol == false) { count = 1; previousSymbol = true; }
                if (c != item) previousSymbol = false;
                maxCount = Math.Max(maxCount, count);
            }
            return maxCount;
        }                                                                                                            
    }
}
