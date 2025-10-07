using Tyuiu.GaninAS.Sprint1.Task7.V28.Lib;

namespace Tyuiu.GaninAS.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(0.256, result);
        }
    }
}