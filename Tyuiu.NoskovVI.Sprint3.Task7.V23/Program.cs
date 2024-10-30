using Tyuiu.NoskovVI.Sprint3.Task7.V23.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task7.V23
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
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функций,           *");
            Console.WriteLine("* в заданном диапазоне с шагом 1.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите начало диапазона: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] valueArray = ds.GetMassFunction(start, end);

            Console.WriteLine("+----------|----------+");
            Console.WriteLine("|          |          |");
            Console.WriteLine("|    X     |   F(x)   |");
            Console.WriteLine("|          |          |");
            Console.WriteLine("+----------|----------+");
            for (int i = 0; i < valueArray.Length; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,5:f2}   |", start, valueArray[i]);
                start++;
            }
            Console.WriteLine("+----------|----------+");
        }
    }
}
