using Tyuiu.NoskovVI.Sprint3.Task1.V28.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue, endValue;
            double a;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* произведение ряда по формуле, при X=0,25                                *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение а: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите начало серии: ");
            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите конец серии: ");
            endValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSeries(a, startValue, endValue));


        }
    }
}
