using System;

namespace Lab1_2;


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


        double y;
        do
        {
            Console.WriteLine("Введите  y");
            string input = Console.ReadLine();
            isCorrect = double.TryParse(input, out y);
            if (!isCorrect)
            {
                Console.WriteLine("Введено неподходящее значение");
            }

        } while (!isCorrect);

        bool isInsideTriangular = ((y <= x/2 + 5) && (y >= -x/2 - 5) && (x >= -10) && (x <= 0));
        bool isInsideCircle = (Math.Sqrt((x-5)*(x-5)+(y * y)) <= 5);

        if ((isInsideTriangular) || (isInsideCircle))
        {
            Console.WriteLine($"Точка с координатами x = {x} и y = {y} принадлежит закрашенной области");
        }
        else
        {
            Console.WriteLine($"Точка с координатами x = {x} и y = {y} не принадлежит закрашенной области");
        }
    }
}