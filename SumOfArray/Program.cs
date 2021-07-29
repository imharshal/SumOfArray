using System;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int sum=0;
            Console.WriteLine("Enter 10 numbers in array");
            for(int i = 0; i<10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int i in arr)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of array: {0}", sum);
        }
    }
}
