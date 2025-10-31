using Tyuiu.PetrovDR.Sprint3.Task5.V5.Lib;


namespace Tyuiu.PetrovDR.Sprint3.Task5.V5
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
            PrintCenteredLine("Задание #5", width);
            PrintCenteredLine("Вариант #5", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Вычислить значение выражения при Х=5.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            Console.WriteLine("X = " + x);
            Console.WriteLine("Старт шага 1 = " + startValue1);
            Console.WriteLine("Конец шага 1 = " + stopValue1);
            Console.WriteLine("Старт шага 2 = " + startValue2);
            Console.WriteLine("Конец шага 2 = " + stopValue2);

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            Console.WriteLine("Значение выражения = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadKey();
        }
    }
}