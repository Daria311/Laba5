using System;
namespace Laba5prod
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().Replace("-", "");

            if (CheckNumber(number))
            {
                Console.WriteLine(Sum(number));
            }
            else
            {
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