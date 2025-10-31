using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PetrovDR.Sprint3.Task4.V5.Lib
{
    public class DataService : ISprint3Task4V5
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res += (Math.Cos(x) - Math.Sin(x)) / x;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
