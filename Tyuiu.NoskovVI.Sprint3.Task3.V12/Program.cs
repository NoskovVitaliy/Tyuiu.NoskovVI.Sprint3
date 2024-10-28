using Tyuiu.NoskovVI.Sprint3.Task3.V12.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? value;
            char item;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach посчитать максимальное количество букв k,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите необходимую строку: ");
            value = Console.ReadLine();

            Console.WriteLine("\nВведите букву, которую необходимо найти: ");
            item = (char)Console.Read();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество букв {item}, идущих подряд равно " + ds.GetMaxCharCount(value, item));

        }
    }
}
