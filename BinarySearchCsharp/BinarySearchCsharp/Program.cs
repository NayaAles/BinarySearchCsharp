using System;

namespace BinarySearchCsharp
{
    using System.Collections.Generic;

    public class Program
    {
        public static int BinarySearch(List<int> numbers, int find)
        {
            int min = 0;
            int max = numbers.Count - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (find == numbers[mid])
                {
                    return mid;
                }
                else if (find < numbers[mid])
                {
                    max = mid - 1;
                }
                else if (find > numbers[mid])
                {
                    min = mid + 1;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = BinarySearch(numbers, 6);
            Console.WriteLine(result);
            
            numbers = new List<int> { -10, -9, -8, -7, -6, -5 };
            result = BinarySearch(numbers, -7);
            Console.WriteLine(result);
        }
    }
}