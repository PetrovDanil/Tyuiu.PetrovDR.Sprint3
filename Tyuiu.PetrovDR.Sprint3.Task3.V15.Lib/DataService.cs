using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PetrovDR.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            int min = 1000000;

            foreach (char c in value)
            {
                if (c == 'm')
                    count++;
                else
                {
                    if (count <= 1)
                        count = 0;
                    else
                    {
                        if (min > count)
                        {
                            min = count;
                        }
                        count = 0;
                    }

                }
            }
            return min;
        }
    }
}
