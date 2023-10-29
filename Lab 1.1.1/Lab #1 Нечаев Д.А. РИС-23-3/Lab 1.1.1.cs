using System;



namespace Lab1_1_1 {

    class Programm
    {
        static void Main()
        {

            double m;
            bool isCorrect;
            do
            {
                Console.WriteLine("Введите  m");
                string input = Console.ReadLine();
                isCorrect = double.TryParse(input, out m);
                if (!isCorrect)
                {
                    Console.WriteLine("Введено неподходящее значение");
                }

            } while (!isCorrect);

            double n;
            do
            {
                Console.WriteLine("Введите n");
                string input = Console.ReadLine();
                isCorrect = double.TryParse(input, out n);

                if (!isCorrect)
                {
                    Console.WriteLine("Введено неподходящее значение");   
                }
            } while(!isCorrect);

            Console.WriteLine($"m = {m} n = {n}");
            double First = m + --n;
            Console.WriteLine($"m+--n = {First}");

        }
    }
}