using System;

namespace Lab1_3;
class Programm
{
    static void Main()
    {

        char s;
        bool isCorrect;
        do
        {
            Console.WriteLine("Введите d для просчёта в типе double, f для просчёта в типе float");
            string input = Console.ReadLine();
            isCorrect = char.TryParse(input, out s);
            if (!isCorrect)
            {
                Console.WriteLine("Введено неподходящее значение");
            }

        } while ((!isCorrect) && ((!(s =='f'))||(!(s =='d'))));

        if (s == 'd')
        {
            double a = 1000;
            double b = 0.0001;
            double First = Math.Pow(a - b, 3);
            double Second = Math.Pow(a, 3);
            double Third = Math.Pow(b, 3);
            double Fourth = 3 * a * Math.Pow(b, 2);
            double Fifth = 3 * Math.Pow(a, 2) * b;
            double Finish = (First - Second) / (-Third + Fourth - Fifth);
            Console.WriteLine("a = 1000, b = 0.0001");
            Console.WriteLine($"Значение выражения в типе double = {Finish}");
        }
        else
        {
            float a = (float)1000;
            float b = (float)0.0001;
            float First = (float)Math.Pow(a - b, 3);
            float Second = (float)Math.Pow(a, 3);
            float Third = (float)Math.Pow(b, 3);
            float Fourth = (float)(3 * a * Math.Pow(b, 2));
            float Fifth = (float)(3 * Math.Pow(a, 2) * b);
            float Finish = (float)((First - Second) / (-Third + Fourth - Fifth));
            Console.WriteLine("a = 1000, b = 0.0001");
            Console.WriteLine($"Значение выражения в типе float = {Finish}");
        }
    }
}