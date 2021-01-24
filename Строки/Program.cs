using System;

namespace Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.Replace(" ", string.Empty);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
