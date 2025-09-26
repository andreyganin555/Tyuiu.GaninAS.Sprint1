using Tyuiu.GaninAS.Sprint1.Task1.V20.Lib;

namespace Tyuiu.GaninAS.Sprint1.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(11, res);
        }
    }
}
