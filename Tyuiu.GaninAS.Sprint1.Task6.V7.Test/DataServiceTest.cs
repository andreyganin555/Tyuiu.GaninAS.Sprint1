using Tyuiu.GaninAS.Sprint1.Task6.V7.Lib;

namespace Tyuiu.GaninAS.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strText = "Хороший день";
            string res = ds.DeleteLastLetter(strText);
            string wait = "Хороши ден";
            Assert.AreEqual(wait, res);
        }
    }
}


