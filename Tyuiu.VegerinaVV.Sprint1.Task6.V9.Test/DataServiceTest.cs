using Tyuiu.VegerinaVV.Sprint1.Task6.V9.Lib;

namespace Tyuiu.VegerinaVV.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string srtTest = "hello world";
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(srtTest);
            string wait = "ohell dworl";
            Assert.AreEqual(wait, res);

        }
    }
}
