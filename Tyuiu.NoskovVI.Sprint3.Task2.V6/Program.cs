using Tyuiu.NoskovVI.Sprint3.Task2.V6.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue, endValue;
            double value;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле, при a=0,25                                *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите начало ряда: ");
            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите конец ряда: ");
            endValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите значение а: ");
            value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда равно:"+ds.GetMultiplySeries(value,startValue,endValue));

        }
    }
}
