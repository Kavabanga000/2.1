using System;

namespace FunctionValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента x:");
            double x = double.Parse(Console.ReadLine());

            if (x != 2)
            {
                double y = Math.Log(Math.Abs(x - 2));
                Console.WriteLine($"Значение функции при x = {x} равно {y}");
            }
            else
            {
                Console.WriteLine($"Недопустимое згачение x ");
            }
        }
    }
}