using System;

namespace PrecedencePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            sum = 10 - 2 * 5;
            Console.Write("Default Order: " + sum + "\n");

            sum = (10 - 2) * 5;
            Console.Write("Forced Order:" + sum + "\n");

            sum = 100 * 5 / 6 + 50;
            Console.WriteLine("Random Example of Default Ordering: " + sum);

            sum = 100 * 5 / (6 + 50);
            Console.WriteLine("Random Example of Forced Ordering:" + sum);


            //the compiler goes from left to right, or simply ------------>
            sum = 7 - 4 + 2;
            Console.WriteLine("Example of Default Direction: " + sum);


            // The compiler goes from right to left, or simply <----------
            sum = 7 - (4 + 2);
            Console.WriteLine("Example of Forced Direction: " + sum);

            Console.WriteLine("T-t-t-t-t-t-t-t-tt that's all folks!");


        }
    }
}
