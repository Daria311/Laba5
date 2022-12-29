using System;
namespace Laba5prod
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            CheckNumber(number);
        }
        static void CheckNumber(string number)
        {
            int summa = 0;
            if (true)
            { 
                foreach (char c in number)
                {
                    summa += c - '0';
                }
                Console.WriteLine(summa);
            }
            else
            {
                Console.WriteLine("Некорректно");
            }
        }
    }
}