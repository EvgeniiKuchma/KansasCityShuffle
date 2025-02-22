using System;

namespace KansasCityShuffle
{
    internal class Program
    {

        static void Shaffle(int[] numbers)
        {
            Random random = new Random();
            int numberRandom;
            int temp;

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                numberRandom = random.Next(i + 1);
                temp = numbers[numberRandom];
                numbers[numberRandom] = numbers[i];
                numbers[i] = temp;
            }
           
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Shaffle(numbers);
        }
    }
}
