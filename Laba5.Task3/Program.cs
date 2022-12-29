using System;
namespace Laba5.Task3
{
    class Programm
    {
        static void Main()
        {
            string[] array = new string[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            Print(array);
            string[] array2 = WorkArray(array);
            Print(array2);
        }
        static void Print(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine();
        }
        static string[] WorkArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(array[i], out int res))
                {
                    if (res > 0)
                    {
                        array[i] = Factorial(res).ToString();
                    }
                }
                else if (double.TryParse(array[i], out double res2))
                {
                    res2 = Math.Round(res2, 2);
                    string[] parts = res2.ToString().Split(',');
                    array[i] = parts[1];
                }
            }
            return array;
        }
        static long Factorial(int i)
        {
            if (i == 1) return 1;
            return i * Factorial(i - 1);
        }
    }
}
