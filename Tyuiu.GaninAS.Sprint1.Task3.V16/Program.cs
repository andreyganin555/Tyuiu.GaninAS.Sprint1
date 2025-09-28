using Tyuiu.GaninAS.Sprint1.Task3.V16.Lib;
namespace Tyuiu.GaninAS.Sprint1.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Операторы составного присваивания                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, в*");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.              *");

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите первый корень x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второй корень x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
          

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var result = ds. CoeffOfQuadraticEquation(x1, x2);
            Console.WriteLine("Коэффициент приведенного квадратного уравнения " + result);
            Console.ReadKey();
        }
    }
}