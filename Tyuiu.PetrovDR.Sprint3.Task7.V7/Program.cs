using System.Data.Common;
using Tyuiu.PetrovDR.Sprint3.Task7.V7.Lib;


namespace Tyuiu.PetrovDR.Sprint3.Task7.V7
{
    class Program
    {

        static void Main(string[] args)
        {
            void PrintCenteredLine(string text, int totalWidth)
            {
                var padding = totalWidth - text.Length - 2;
                Console.WriteLine($"* {text}{new string(' ', padding)}*");
            }
            var width = 100;



            DataService ds = new DataService();

            PrintCenteredLine("Спринт #3 | Выполнил: Петров Д. Р. | РППб-25-1", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("Спринт #3", width);
            PrintCenteredLine("Тема: Алгоритмы циклической структуры", width);
            PrintCenteredLine("Задание #7", width);
            PrintCenteredLine("Вариант #7", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Написать программу, которая выводит таблицу значений функции.", width);

            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            int startValue = -5;
            int stopValue = 15;

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            Console.WriteLine(new string('*', width));
            Console.WriteLine("    X       |       f(X)     |");
            Console.WriteLine(new string('*', width));
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("{0,5:d}       |       {1, 7:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine(new string('*', width));
            Console.ReadKey();
        }
    }
}