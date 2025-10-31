using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PetrovDR.Sprint3.Task6.V13.Lib
{
    public class DataService : ISprint3Task6V13
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int SumTD = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        if (j > 8)
                        {
                            SumTD += j;
                        }
                    }
                }
            }
            return SumTD;
        }
    }
}
