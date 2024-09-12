using System;

namespace zadachaa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string result = Replacee();
            Console.WriteLine(result);
        }
        static string Replacee()
        {
            string b = Console.ReadLine().Replace(".", "...");
            return b;
        }
    }
}
