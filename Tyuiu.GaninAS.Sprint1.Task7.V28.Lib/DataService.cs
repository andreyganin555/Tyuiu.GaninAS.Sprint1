using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GaninAS.Sprint1.Task7.V28.Lib
{
    public class DataService : ISprint1Task7V28
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow(Math.Cos(x), 2) * Math.Pow(Math.Sin(x), 1 / 2) + Math.Pow(1, 2);
            return Math.Round(res, 3); 
        }
    }
}