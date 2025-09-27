using Tyuiu.VegerinaVV.Sprint1.Task2.V24.Lib;

namespace Tyuiu.VegerinaVV.Sprint1.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 3;
            var res = ds.CalculateDiffSquare(x, y);
            Assert.AreEqual(4, res);
        }
    }
}
