using System;
using zadacha_biblioteki;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[4, 8];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.WriteLine("Введите значение  m[" + i + ", " + j + "]: ");
                    mas[i, j] = int.Parse(Console.ReadLine());

                }
            }
            double pow = zadacha_biblioteki.Class1.geo(mas);
            Console.WriteLine(pow);
        }
    }
}
