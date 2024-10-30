    namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int sum = 0, sumd = 0;
            int count1 = 0;
            for (x = 2; x<= 5; x++)
            {
                for (int d = 1; d<=x; d++)
                {
                    if (x%d == 0)
                    {
                        count1++;

                    }
                }
            }
            Console.WriteLine(count1);
        }
    }
}
