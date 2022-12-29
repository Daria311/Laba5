using System;
namespace Laba5
{
    class Program
    {
        public static void Main()
        {
            string b = "9";
            while (true)
            {
                var a = Console.ReadLine();
                if (a == "q")
                {
                    break;
                }
                else if (int.TryParse(a, out var result))
                {
                    Console.WriteLine((char)result);
                }
                else if (float.TryParse(a, out var result2))
                {
                    
                    if (Math.Abs(result2 - float.Parse(b)) < 0.0001)
                    {
                        break;
                    }
                }
                b = a;  
            }
        }
    } 
}