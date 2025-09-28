using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VegerinaVV.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            double res = (f / 360) * 12;
            int result = Convert.ToInt32(Math.Floor(res));
            return result;
        }
    }
}
