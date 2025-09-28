using Tyuiu.VegerinaVV.Sprint1.Task5.V7.Lib;

namespace Tyuiu.VegerinaVV.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 120;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);
            int result = Convert.ToInt32(res);
            int wait = 4;
            Assert.AreEqual(wait, result);
        }
    }
}
