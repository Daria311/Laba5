using System;
namespace Laba5prod
{
    class Program
    {
        static void Main()
        static void Main(string[] args)
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
            string number = Console.ReadLine().Replace("-", "");

            if (CheckNumber(number))
            {
                Console.WriteLine(Sum(number));
            }
            else
            {
                Console.WriteLine("Некорректно");
                Console.WriteLine("Некорректные данные!");
            }
        }

        static bool CheckNumber(string n)
        {
            bool isNumber = true;

            foreach (char s in n)
            {
                if (!char.IsDigit(s))
                    return false;
            }

            return isNumber;
        }

        static double Sum(string n)
        {
            double sum = 0;

            foreach (char s in n)
                sum += char.GetNumericValue(s);

            return sum;
        }
    }
}