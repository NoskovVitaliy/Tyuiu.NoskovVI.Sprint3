using Tyuiu.NoskovVI.Sprint3.Task5.V26.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task5.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, start1, start2, end1, end2;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти значение функции                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите начало первой серии: ");
            start1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите конец первой серии: ");
            end1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите начало второй серии: ");
            start2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите конец второй серии: ");
            end2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(x, start1, start2, end1, end2));
        }
    }
}
