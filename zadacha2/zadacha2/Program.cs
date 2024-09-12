using System;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Финик.Бабуинцев";

            string[] words = text.Split(new char[] { '.' });
        

            string first = words[0];
            string second = words[1];

            Console.WriteLine(first);
            Console.WriteLine(second);
        }
        
    }
}
