using System;

namespace Oran_question
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[100];
            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            Console.WriteLine(sum(0,arr));
            Console.WriteLine(sumR(0,arr));
        }
        public static int sum(int index, int[] arr)
        {
            int sum = 0;
            for (int i = index; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int sumR(int index, int[] arr)
        {
            if (index == arr.Length-1)
            {
                return arr[index];
            }
            else
            {
                return arr[index] + sumR(index + 1, arr);
            }
        }
    }
}
