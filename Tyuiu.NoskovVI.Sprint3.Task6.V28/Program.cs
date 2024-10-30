using Tyuiu.NoskovVI.Sprint3.Task6.V28.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task6.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
            Console.WriteLine("* принадлежащих числовому отрезку [13, 19] количество                     *");
            Console.WriteLine("* всех делителей меньше 7                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите начало отрезка: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите конец отрезка: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество делителей меньше 7 равно: "+ds.GetSumTheDivisors(start, end)); 
        }
    }
}
