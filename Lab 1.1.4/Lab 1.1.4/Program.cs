using System;



namespace Lab1_1_4
{
    class Programm
    {
        static void Main()
        {
            double x;
            bool isCorrect;
            do
            {
                Console.WriteLine("Введите  x");
                string input = Console.ReadLine();
                isCorrect = double.TryParse(input, out x);
                if (!isCorrect)
                {
                    Console.WriteLine("Введено неподходящее значение");
                }

            } while (!isCorrect);

            Console.WriteLine($"x = {x}");
            double Fourth = Math.Acos(x + Math.Pow(x, 2));
            if((x + Math.Pow(x, 2)) >= -1 && (x + Math.Pow(x, 2)) <= 1)
            {
                Console.WriteLine($"arccos(x + x^2) = {Fourth}");
            }
            else
            {
                Console.WriteLine($"При x = {x} функция arccos(x + x^2) не существует");
            }
        }
    }
}