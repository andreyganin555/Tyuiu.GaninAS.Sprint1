using System.Net.WebSockets;
using Tyuiu.GaninAS.Sprint1.Task5.V3.Lib;

namespace Tyuiu.GaninAS.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int h = 9;
            DataService ds = new DataService();
            int k = 130985;
            int res = ds.Calculate(k);
            Assert.AreEqual(h, res);




        }
    }
}
