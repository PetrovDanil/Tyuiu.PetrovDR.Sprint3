using Tyuiu.PetrovDR.Sprint3.Task3.V15.Lib;


namespace Tyuiu.PetrovDR.Sprint3.Task3.V15
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
            PrintCenteredLine("Задание #3", width);
            PrintCenteredLine("Вариант #15", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Используя цикл foreach подсчитать минимальное количество букв m, находящихся на соседних позициях в строке", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            string str = "lrmmse mg sermmmrt";
            char chr = 'm';

            Console.WriteLine("Строка = " + str);
            Console.WriteLine("Символ = " + chr);

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            Console.WriteLine("Минимальное кол-во букв = " + ds.GetMinCharCount(str, chr));

            Console.ReadKey();
        }
    }
}