using Tyuiu.NoskovVI.Sprint3.Task4.V11.Lib;
namespace Tyuiu.NoskovVI.Sprint3.Task4.V11
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
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить              *");
            Console.WriteLine("* значение функции y=x/(sin(x) - x)+2. При х = 0 пропустить значение      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите начало цикла: ");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите конец цикла: ");
            end = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(start, end));
        }
    }
}
