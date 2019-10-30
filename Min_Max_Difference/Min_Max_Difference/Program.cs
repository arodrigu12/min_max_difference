using System;

namespace Min_Max_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theNums = { 15, 22, 84, 14, 88, 23 };

            int max = -99;
            int min = 999;

            foreach (int item in theNums)
            {
                if (item < min)
                {
                    min = item;
                }
                else if (item > max)
                {
                    max = item;
                }
            }


            Console.WriteLine("min = {0} - max = {1} - difference = {2}", min, max, max - min);

            Console.ReadLine();
        }
    }
}