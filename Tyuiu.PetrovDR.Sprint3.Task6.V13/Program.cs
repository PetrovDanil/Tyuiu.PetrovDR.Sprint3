using Tyuiu.PetrovDR.Sprint3.Task6.V13.Lib;


namespace Tyuiu.PetrovDR.Sprint3.Task6.V13
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
            PrintCenteredLine("Задание #6", width);
            PrintCenteredLine("Вариант #13", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Напишите программу, которая ищет среди целых чисел, принадлежащих ", width);
            Console.WriteLine("числовому отрезку [8, 17] сумму всех делителей больше 8.", width);

            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            int startValue = 8;
            int stopValue = 17;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey();
        }
    }
}