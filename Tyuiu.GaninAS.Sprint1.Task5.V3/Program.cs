using Tyuiu.GaninAS.Sprint1.Task5.V3.Lib;
namespace Tyuiu.GaninAS.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Преобразование типов и класс Convert                                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Присвоить целой переменной h третью от конца цифру в записи положительног*");
            Console.WriteLine("*о целого числа k (например, если k=130985, то h=9)                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите k=130985 : ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: h =                                                          *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int res = ds.Calculate(k);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}