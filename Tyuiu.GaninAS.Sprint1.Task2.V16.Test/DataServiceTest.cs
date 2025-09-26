using Tyuiu.GaninAS.Sprint1.Task2.V16.Lib;

namespace Tyuiu.GaninAS.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculatePerimetrCircle()
        {
            DataService ds = new DataService();
            int value = 10;
            var res = ds.CalculatePerimetrCircle(value);
            Assert.AreEqual(62.842, res);
        }
    }
}
