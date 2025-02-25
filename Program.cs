using System;

namespace KansasCityShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Shaffle(numbers);
        }

        static void Shaffle(int[] numbers)
        {
            int randomNumbers;
            int temp;

            Random random = new Random();

            for(int i = numbers.Length - 1; i > 0; i--)
            {
                randomNumbers = random.Next(numbers.Length);
                temp = numbers[i];
                numbers[i] = numbers[randomNumbers];
                numbers[randomNumbers] = temp;
            }

            for(int i = 0;  i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
