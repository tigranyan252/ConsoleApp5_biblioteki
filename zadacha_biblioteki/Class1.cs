using System;

namespace zadacha_biblioteki
{
    public class Class1
    {
        public static double geo(int[,] mas)
        {
            int proiz = 1;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    proiz *= mas[i, j];
                }
            }
            double pow = Math.Pow(proiz, (1.0 / 3.0));
            return (pow);
        }
    }
}
