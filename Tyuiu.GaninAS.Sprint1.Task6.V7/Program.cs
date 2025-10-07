using Tyuiu.GaninAS.Sprint1.Task6.V7.Lib;
namespace Tyuiu.GaninAS.Sprint1.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Работа со строками класс String                                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу: пользователь вводит текст. Напечатать все слова, удал*");
            Console.WriteLine("*ив из них последнюю букву.                                               *");
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(ds.DeleteLastLetter(str));
            Console.ReadKey();
        }
    }
}