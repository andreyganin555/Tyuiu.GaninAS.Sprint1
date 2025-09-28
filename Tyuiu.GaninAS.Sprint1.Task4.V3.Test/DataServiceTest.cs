using Tyuiu.GaninAS.Sprint1.Task4.V3.Lib;
namespace Tyuiu.GaninAS.Sprint1.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.449489742783178, res);
        }
    }
}
