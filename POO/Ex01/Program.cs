using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue, maxValue;

            int[] randNums = new int[5];

            Random rand = new Random();

            minValue = Convert.ToInt32(args[0]);
            maxValue = Convert.ToInt32(args[1]);

            if (minValue > maxValue)
            {
                int temp = minValue;
                minValue = maxValue;
                maxValue = temp;
            }

            for (int i = 0; i < randNums.Length; i++)
            {
                randNums[i] = rand.Next(minValue, maxValue + 1);
                Console.WriteLine(randNums[i]);
            }
        }
    }
}
