using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PetrovDR.Sprint3.Task5.V5.Lib
{
    public class DataService : ISprint3Task5V5
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double SumSeries = 0;

            for (int i  = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    SumSeries += x / (Math.Sin(j));
                }
            }
            return Math.Round(SumSeries, 3);
        }
    }
}
