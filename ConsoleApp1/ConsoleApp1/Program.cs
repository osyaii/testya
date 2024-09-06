using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Summa(1));
           
        }
        static double Summa(double x)
        {
            double summaaa = 0;
            for (int i = 1; i <= 10; i++)
            {
                summaaa += Math.Pow(x, i) / (i + x);
            }
            return summaaa;
        }
    }
}
