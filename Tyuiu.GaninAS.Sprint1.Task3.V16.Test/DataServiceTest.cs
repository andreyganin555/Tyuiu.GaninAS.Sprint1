using Tyuiu.GaninAS.Sprint1.Task3.V16.Lib;

namespace Tyuiu.GaninAS.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double x2 = 3;
            double b = -5;
            var res = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(b, res);
        }
    }
}





